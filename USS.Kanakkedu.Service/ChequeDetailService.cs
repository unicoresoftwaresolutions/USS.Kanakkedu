
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class ChequeDetailService : BaseService<ChequeDetail>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public ChequeDetailService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
