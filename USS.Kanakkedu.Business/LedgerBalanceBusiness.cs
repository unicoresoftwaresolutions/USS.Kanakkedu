
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class LedgerBalanceBusiness : BaseBusiness<LedgerBalance>, ILedgerBalanceBusiness
    {
        public LedgerBalanceBusiness(ILedgerBalanceData data) : base(data)
        {

        }
    }
}
