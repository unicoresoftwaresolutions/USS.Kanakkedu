
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class ACYearBusiness : BaseBusiness<ACYear>, IACYearBusiness
    {
        public ACYearBusiness(IACYearData data) : base(data)
        {

        }
    }
}
