
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class ACGroupData : BaseData<ACGroup>, IACGroupData
    {
        public ACGroupData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
