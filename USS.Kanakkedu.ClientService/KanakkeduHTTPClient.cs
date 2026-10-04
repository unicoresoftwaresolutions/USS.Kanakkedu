namespace USS.Kanakkedu.ClientService
{
    public class KanakkeduHTTPClient
    {
        public readonly FundService Fund;
        public readonly HttpClient client;
        public KanakkeduHTTPClient(HttpClient http)
        {
            client = http;
            Fund = new (client);
        }

    }
}
