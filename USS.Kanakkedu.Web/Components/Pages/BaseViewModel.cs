using USS.Kanakkedu.ClientService;

namespace USS.Kanakkedu.Web.Components.Pages
{
    public class BaseViewModel<T> where T : class
    {
        private KanakkeduHTTPClient http { get; set; }
        private BaseService<T> service { get; set; }
        private bool IsDeleteModal { get; set; } = false;
        private List<BaseModel<T>> Datas { get; set; } 
        private Guid Id { get; set; }

        public BaseViewModel(KanakkeduHTTPClient http)
        {
            this.http = http;
            Datas = new List<BaseModel<T>>();
            service = new BaseService<T>(http.client);
        }

        async void OnDeleteClose(string value)
        {
            if (value == "Ok")
            {
                await http.Fund.DeleteAsync(Id);
                await GetData();
            }
        }

        async Task GetData()
        {
            var result = await service.AllAsync();
            Datas = result.Select(x => new BaseModel<T>() { data = x, IsEdit = false }).ToList();
            //StateHasChanged();
        }
        async void Add()
        {
            BaseModel<T> fund = new() {IsEdit = true };
            Datas.Add(fund);
        }
        async void Edit(BaseModel<T> f)
        {
            f.IsEdit = true;
            f.EditData = default;
        }
        async void Delete(BaseModel<T> f)
        {
            //Id = f.data.Id;
            IsDeleteModal = true;
        }
        async void Save(BaseModel<T> f)
        {
            f.IsEdit = false;
            if (f.data.Id == default)
            {
                f.EditData.Id = Guid.NewGuid();
                var result = await service.InsertAsync(f.EditData);
            }
            else
            {
                var result = await service.UpdateAsync(f.EditData);
            }
            await GetData();

        }
        void Cancel(BaseModel<T> f)
        {

            if (f.data.Id == default) Datas.Remove(f);
            else f.IsEdit = false;
        }

    }
}
