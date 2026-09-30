using System;
using System.Collections.Generic;
using System.Text;
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

        public DbSet<Fund> Funds { get; set; }
    }
}
