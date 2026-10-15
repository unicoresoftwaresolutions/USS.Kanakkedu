
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class ChequeDetailBusiness : BaseBusiness<ChequeDetail>, IChequeDetailBusiness
    {
        public ChequeDetailBusiness(IChequeDetailData data) : base(data)
        {

        }
    }
}
