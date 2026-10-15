
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class ReceiptData : BaseData<Receipt>, IReceiptData
    {
        public ReceiptData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
