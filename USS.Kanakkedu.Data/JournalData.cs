
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class JournalData : BaseData<Journal>, IJournalData
    {
        public JournalData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
