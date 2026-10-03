using System.Net.Http.Json;
using System.Text.Json;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.ClientService
{
    public class KanakkeduHTTPClient
    {
        private readonly HttpClient client;
        public KanakkeduHTTPClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<Fund>> FundAllAsync()
        {
            return await client.GetFromJsonAsync<List<Fund>>("Fund");
        }

        public async Task<Fund> InsertFundAsync(Fund data)
        {
            var result = await client.PostAsJsonAsync<Fund>("Fund", data);

            return data;
        }

        public async Task<Fund> UpdateFundAsync(Fund data)
        {
            var result = await client.PutAsJsonAsync<Fund>("Fund", data);
            return data;
        }

        public async Task<bool> DeleteFundAsync(Guid Id)
        {
            var result = await client.DeleteAsync($"Fund/{Id}");
            return true;
        }
    }
}
