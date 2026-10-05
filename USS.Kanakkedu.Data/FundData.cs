using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public class FundData : BaseData<Fund>, IFundData
    {
        public FundData(KanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
