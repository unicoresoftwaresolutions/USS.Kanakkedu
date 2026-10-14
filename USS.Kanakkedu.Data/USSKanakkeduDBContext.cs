using Microsoft.EntityFrameworkCore;
using USS.Kanakkedu.Model;

namespace USS.Kanakkedu.Data
{
    public class USSKanakkeduDBContext:DbContext 
    {
        public USSKanakkeduDBContext(DbContextOptions<USSKanakkeduDBContext> options)
            : base(options)
        {
            
        }

        public DbSet<Fund> Fund { get; set; }
        public DbSet<JournalType> JournalType { get; set; }
    }
}
