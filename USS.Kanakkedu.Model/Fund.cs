using USS.Base.Model;

namespace USS.Kanakkedu.Model
{
    public partial class Fund : BaseEntityModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }        
    }
}
