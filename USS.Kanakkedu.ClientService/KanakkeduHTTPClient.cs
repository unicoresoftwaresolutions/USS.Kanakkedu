namespace USS.Kanakkedu.ClientService
{
    public class KanakkeduHTTPClient
    {
        public readonly FundService Fund;
        public KanakkeduHTTPClient(HttpClient http)
        {
            Fund = new (http);
        }

    }
}
