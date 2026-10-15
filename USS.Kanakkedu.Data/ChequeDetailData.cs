
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class ChequeDetailData : BaseData<ChequeDetail>, IChequeDetailData
    {
        public ChequeDetailData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
