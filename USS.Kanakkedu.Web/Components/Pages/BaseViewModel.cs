using Microsoft.AspNetCore.Components;
using USS.Kanakkedu.ClientService;
using USS.Kanakkedu.Extension;

namespace USS.Kanakkedu.Web.Components.Pages
{
    public class BaseViewModel<T>:ComponentBase where T : new()
    {
        protected KanakkeduHTTPClient http { get; set; }
        protected BaseService<T> service { get; set; }
        protected bool IsDeleteModal { get; set; } = false;
        protected List<BaseModel<T>> Datas { get; set; }
        protected Guid Id { get; set; }

        public BaseViewModel(KanakkeduHTTPClient http)
        {
            this.http = http;
            Datas = new List<BaseModel<T>>();
            service = new BaseService<T>(http.client);
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
            Datas = result.Select(x => new BaseModel<T>() { data = x, IsEdit = false }).ToList();
            StateHasChanged();
        }
        public async void Add()
        {
            BaseModel<T> data = new() {IsEdit = true, data = new T(), EditData = new T() };
            Datas.Add(data);
        }
        public async void Edit(BaseModel<T> f)
        {
            f.IsEdit = true;
            var m = f.data.GetType().GetMethod("Clone");
            f.EditData = (T)m.Invoke(f.data, null);
        }
        public async void Delete(BaseModel<T> f)
        {
            Id = Guid.Parse(f.data.GetPropertyValue(nameof(Id)).ToString());
            IsDeleteModal = true;
        }
        public  async void Save(BaseModel<T> f)
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
        public void Cancel(BaseModel<T> f)
        {

            if (Guid.Parse(f.data.GetPropertyValue(nameof(Id)).ToString()) == default) Datas.Remove(f);
            else f.IsEdit = false;
        }

    }
}
