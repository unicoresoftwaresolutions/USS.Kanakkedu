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

        public void FundAllAsync()
        {
            var result = client.GetAsync("/Fund");
        }
    }
}
