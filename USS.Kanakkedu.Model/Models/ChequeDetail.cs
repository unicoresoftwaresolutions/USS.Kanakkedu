

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class ChequeDetail : BaseEntityModel
    {

        public string No { get; set; }
        public DateOnly Date { get; set; }
        public DateOnly ClearedAt { get; set; }
    
    
    
    }
}
