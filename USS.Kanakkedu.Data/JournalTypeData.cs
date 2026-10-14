using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class JournalTypeData : BaseData<JournalType>, IJournalTypeData
    {
        public JournalTypeData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
