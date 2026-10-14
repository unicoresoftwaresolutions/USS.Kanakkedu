

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class Receipt : BaseEntityModel
    {

        public Guid JournalId { get; set; }
        public Guid TransactionTypeId { get; set; }
        public Guid TransactionDetailId { get; set; }
    
        public Journal Journal { get; set; }
        public TransactionType TransactionType { get; set; }
    
    
    }
}
