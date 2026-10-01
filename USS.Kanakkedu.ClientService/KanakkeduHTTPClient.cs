using System.Net.Http.Json;
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

        public async Task<ICollection<Fund>> FundAllAsync()
        {
            return await client.GetFromJsonAsync<ICollection<Fund>>("/Fund");
        }
    }
}
