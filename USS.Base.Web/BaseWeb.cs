using Microsoft.AspNetCore.Components;
using USS.Base.Extension;
using USS.Base.Model;
using USS.Base.Service;

namespace USS.Base.Web
{
    public class BaseWeb<T> : ComponentBase where T : new()
    {
        protected HttpClient http { get; set; }
        protected BaseService<T> service { get; set; }
        protected bool IsDeleteModal { get; set; } = false;
        protected List<BaseGridModel<T>> Datas { get; set; }
        protected Guid Id { get; set; }
        public BaseWeb(HttpClient http)
        {
            this.http = http;
            Datas = new List<BaseGridModel<T>>();
            service = new BaseService<T>(http);
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await GetData();
        }
        public async void OnDeleteClose(string value)
        {
            if (value == "Ok")
            {
                await service.DeleteAsync(Id);
                await GetData();
            }
        }

        public async Task GetData()
        {
            var result = await service.AllAsync();
            Datas = result.Select(x => new BaseGridModel<T>() { data = x, IsEdit = false }).ToList();
            StateHasChanged();
        }
        public async void Add()
        {
            BaseGridModel<T> data = new() { IsEdit = true, data = new T(), EditData = new T() };
            Datas.Add(data);
        }
        public async void Edit(BaseGridModel<T> f)
        {
            f.IsEdit = true;
            var m = f.data.GetType().GetMethod("Clone");
            f.EditData = (T)m.Invoke(f.data, null);
        }
        public async void Delete(BaseGridModel<T> f)
        {
            Id = Guid.Parse(f.data.GetPropertyValue(nameof(Id)).ToString());
            IsDeleteModal = true;
        }
        public async void Save(BaseGridModel<T> f)
        {
            f.IsEdit = false;
            if (Guid.Parse(f.data.GetPropertyValue(nameof(Id)).ToString()) == default)
            {
                f.EditData.SetPropertyValue(nameof(Id), Guid.NewGuid());
                var result = await service.InsertAsync(f.EditData);
            }
            else
            {
                var result = await service.UpdateAsync(f.EditData);
            }
            await GetData();

        }
        public void Cancel(BaseGridModel<T> f)
        {

            if (Guid.Parse(f.data.GetPropertyValue(nameof(Id)).ToString()) == default) Datas.Remove(f);
            else f.IsEdit = false;
        }
    }
}
