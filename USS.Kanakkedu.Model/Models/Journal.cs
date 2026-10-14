

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class Journal : BaseEntityModel
    {

        public Guid JournalTypeId { get; set; }
        public string EntryNo { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string RefNo { get; set; }
    
        public JournalType JournalType { get; set; }
    
        public List<JournalDetail> JournalDetails { get; set; }
        public List<Payment> Payments { get; set; }
        public List<Receipt> Receipts { get; set; }
    
    }
}
