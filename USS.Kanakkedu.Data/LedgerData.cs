
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class LedgerData : BaseData<Ledger>, ILedgerData
    {
        public LedgerData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
