using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class FundService : BaseService<Fund>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public FundService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
