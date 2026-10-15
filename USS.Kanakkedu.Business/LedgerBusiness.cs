
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class LedgerBusiness : BaseBusiness<Ledger>, ILedgerBusiness
    {
        public LedgerBusiness(ILedgerData data) : base(data)
        {

        }
    }
}
