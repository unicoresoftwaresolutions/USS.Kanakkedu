namespace USS.Kanakkedu.Model
{
    public class Fund : ICloneable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
