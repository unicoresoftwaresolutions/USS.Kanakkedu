
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class JournalBusiness : BaseBusiness<Journal>, IJournalBusiness
    {
        public JournalBusiness(IJournalData data) : base(data)
        {

        }
    }
}
