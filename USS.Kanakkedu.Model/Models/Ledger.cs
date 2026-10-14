

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class Ledger : BaseEntityModel
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public Guid ACGroupId { get; set; }
    
        public ACGroup ACGroup { get; set; }
    
        public List<LedgerBalance> LedgerBalances { get; set; }
        public List<JournalDetail> JournalDetails { get; set; }
    
    }
}
