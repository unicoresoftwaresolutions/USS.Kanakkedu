
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class LedgerBalanceService : BaseService<LedgerBalance>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public LedgerBalanceService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
