namespace USS.Kanakkedu.Service
{
    public class KanakkeduHTTPClient
    {
        public readonly HttpClient client;
        public KanakkeduHTTPClient(HttpClient http)
        {
            client = http;
        }

    }
}
