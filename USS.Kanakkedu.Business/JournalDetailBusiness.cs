
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class JournalDetailBusiness : BaseBusiness<JournalDetail>, IJournalDetailBusiness
    {
        public JournalDetailBusiness(IJournalDetailData data) : base(data)
        {

        }
    }
}
