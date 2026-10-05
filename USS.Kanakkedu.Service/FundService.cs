using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class FundService:BaseService<Fund>
    {

        public FundService(HttpClient httpClient) : base(httpClient)
        {

        }
        
    }
}
