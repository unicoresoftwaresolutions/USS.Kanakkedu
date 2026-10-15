
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class PaymentData : BaseData<Payment>, IPaymentData
    {
        public PaymentData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
