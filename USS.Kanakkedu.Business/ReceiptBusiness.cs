
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class ReceiptBusiness : BaseBusiness<Receipt>, IReceiptBusiness
    {
        public ReceiptBusiness(IReceiptData data) : base(data)
        {

        }
    }
}
