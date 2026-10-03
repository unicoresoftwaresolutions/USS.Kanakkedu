using Microsoft.EntityFrameworkCore;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public class KanakkeduDBContext:DbContext 
    {
        public KanakkeduDBContext(DbContextOptions<KanakkeduDBContext> options)
            : base(options)
        {
            
        }

        public DbSet<Fund> Fund { get; set; }
        public DbSet<JournalType> JournalType { get; set; }
    }
}
