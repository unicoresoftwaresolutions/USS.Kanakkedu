

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class ACYear : BaseEntityModel
    {

        public string Code { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public bool YearEndClosed { get; set; }
        public Guid FundId { get; set; }
    
        public Fund Fund { get; set; }
    
        public List<LedgerBalance> LedgerBalances { get; set; }
    
    }
}
