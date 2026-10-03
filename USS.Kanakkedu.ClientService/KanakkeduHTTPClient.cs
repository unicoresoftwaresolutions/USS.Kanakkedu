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
    }
}
