
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class JournalDetailData : BaseData<JournalDetail>, IJournalDetailData
    {
        public JournalDetailData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
