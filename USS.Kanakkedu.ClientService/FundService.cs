using System.Net.Http.Json;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.ClientService
{
    public class FundService:BaseService<Fund>
    {

        public FundService(HttpClient httpClient) : base(httpClient)
        {

        }
        
    }
}
