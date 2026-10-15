
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class ReceiptService : BaseService<Receipt>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public ReceiptService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
