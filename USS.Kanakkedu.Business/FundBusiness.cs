using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class FundBusiness : BaseBusiness<Fund>, IFundBusiness
    {
        public FundBusiness(IFundData data) : base(data)
        {

        }
    }
}
