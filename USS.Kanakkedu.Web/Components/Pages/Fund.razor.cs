using USS.Kanakkedu.ClientService;

namespace USS.Kanakkedu.Web.Components.Pages
{
      
    public partial class Fund
    {
        private KanakkeduHTTPClient http { get; set; }

        private bool IsDeleteModal { get; set; } = false;
        private List<FundModel> funds { get; set; }
        private Guid Id { get; set; }

        public Fund(KanakkeduHTTPClient http)
        {
            this.http = http;
        }
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await GetData();
        }

        async Task GetData()
        {
            var result = await http.FundAllAsync();
            funds = result.Select(x => new FundModel() { data = x, IsEdit = false }).ToList();
            StateHasChanged();
        }
        async void Add()
        {
            FundModel fund = new() { data = new(), EditData = new(), IsEdit = true };
            funds.Add(fund);
        }
        async void Edit(FundModel f)
        {
            f.IsEdit = true;
            f.EditData = new() { Id = f.data.Id, Name = f.data.Name, IsActive = f.data.IsActive };
        }
        async void Delete(FundModel f)
        {
            Id = f.data.Id;
            IsDeleteModal = true;
        }
        async void Save(FundModel f)
        {
            f.IsEdit = false;
            if (f.data.Id == default)
            {
                f.EditData.Id = Guid.NewGuid();
                var result = await http.InsertFundAsync(f.EditData);
            }
            else
            {
                var result = await http.UpdateFundAsync(f.EditData);
            }
            await GetData();

        }
        void Cancel(FundModel f)
        {

            if (f.data.Id == default) funds.Remove(f);
            else f.IsEdit = false;
        }
        async void OnDeleteClose(string value)
        {
            if (value == "Ok")
            {
                await http.DeleteFundAsync(Id);
                await GetData();
            }
        }
    }


}
