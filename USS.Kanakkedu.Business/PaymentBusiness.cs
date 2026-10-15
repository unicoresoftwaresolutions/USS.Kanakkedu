
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class PaymentBusiness : BaseBusiness<Payment>, IPaymentBusiness
    {
        public PaymentBusiness(IPaymentData data) : base(data)
        {

        }
    }
}
