
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class ACYearData : BaseData<ACYear>, IACYearData
    {
        public ACYearData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
