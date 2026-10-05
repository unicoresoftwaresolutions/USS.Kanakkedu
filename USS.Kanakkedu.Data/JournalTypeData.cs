using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public class JournalTypeData : BaseData<JournalType>, IJournalTypeData
    {
        public JournalTypeData(KanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
