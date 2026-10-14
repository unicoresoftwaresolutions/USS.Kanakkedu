

using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class Fund : BaseEntityModel
    {

        public string Name { get; set; }
        public bool IsActive { get; set; }
    
    
        public List<ACYear> ACYears { get; set; }
        public List<ACGroup> ACGroups { get; set; }
    
    }
}
