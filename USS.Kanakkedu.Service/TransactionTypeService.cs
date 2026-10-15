
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class TransactionTypeService : BaseService<TransactionType>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public TransactionTypeService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
