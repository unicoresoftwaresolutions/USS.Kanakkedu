

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class JournalDetail : BaseEntityModel
    {

        public Guid JournalId { get; set; }
        public Guid RefId { get; set; }
        public Guid LedgerId { get; set; }
        public decimal DrAmt { get; set; }
        public decimal CrAmt { get; set; }
        public string Descrption { get; set; }
    
        public Journal Journal { get; set; }
        public Ledger Ledger { get; set; }
    
    
    }
}
