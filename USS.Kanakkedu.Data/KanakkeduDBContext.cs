using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace USS.Kanakkedu.Data
{
    internal class KanakkeduDBContext:DbContext 
    {
        public KanakkeduDBContext(DbContextOptions<KanakkeduDBContext> options)
            : base(options)
        {
            
        }

        public DbSet<Fund> Funds { get; set; }
    }
}
