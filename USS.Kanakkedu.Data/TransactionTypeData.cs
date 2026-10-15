
using USS.Base.Data;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public partial class TransactionTypeData : BaseData<TransactionType>, ITransactionTypeData
    {
        public TransactionTypeData(USSKanakkeduDBContext dBContext) : base(dBContext)
        {
        }
    }
}
