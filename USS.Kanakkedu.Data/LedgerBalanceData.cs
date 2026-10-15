
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class LedgerBalanceData : BaseData<LedgerBalance>, ILedgerBalanceData
    {
        public LedgerBalanceData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
