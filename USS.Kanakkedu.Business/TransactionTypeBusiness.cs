
using USS.Base.Business;
using USS.Kanakkedu.Business.Interface;
using USS.Kanakkedu.Data.Interface;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Business
{
    public class TransactionTypeBusiness : BaseBusiness<TransactionType>, ITransactionTypeBusiness
    {
        public TransactionTypeBusiness(ITransactionTypeData data) : base(data)
        {

        }
    }
}
