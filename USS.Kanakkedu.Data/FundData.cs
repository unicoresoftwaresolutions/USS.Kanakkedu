using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class FundData : BaseData<Fund>, IFundData
    {
        public FundData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
