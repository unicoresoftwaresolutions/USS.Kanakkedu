

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class TransactionType : BaseEntityModel
    {

        public string Name { get; set; }
        public string Code { get; set; }
    
    
        public List<Payment> Payments { get; set; }
        public List<Receipt> Receipts { get; set; }
    
    }
}
