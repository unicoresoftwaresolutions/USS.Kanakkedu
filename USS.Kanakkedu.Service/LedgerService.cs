
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class LedgerService : BaseService<Ledger>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public LedgerService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
