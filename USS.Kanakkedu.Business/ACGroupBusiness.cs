
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class ACGroupBusiness : BaseBusiness<ACGroup>, IACGroupBusiness
    {
        public ACGroupBusiness(IACGroupData data) : base(data)
        {

        }
    }
}
