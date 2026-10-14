

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class LedgerBalance : BaseEntityModel
    {

        public Guid LedgerId { get; set; }
        public Guid ACYearId { get; set; }
        public decimal DrAmt { get; set; }
        public decimal CrAmt { get; set; }
    
        public Ledger Ledger { get; set; }
        public ACYear ACYear { get; set; }
    
    
    }
}
