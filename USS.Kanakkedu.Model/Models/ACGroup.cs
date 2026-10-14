

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class ACGroup : BaseEntityModel
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public Guid ParentId { get; set; }
        public Guid FundId { get; set; }
    
        public Fund Fund { get; set; }
    
        public List<Ledger> Ledgers { get; set; }
    
    }
}
