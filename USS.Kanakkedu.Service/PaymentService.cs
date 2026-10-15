
using USS.Base.Service;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Service
{
    public class PaymentService : BaseService<Payment>
    {
        private readonly USSKanakkeduHTTPClient _http;
        public PaymentService(USSKanakkeduHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
