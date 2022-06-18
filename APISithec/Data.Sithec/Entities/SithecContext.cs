using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sithec.Entities
{
    public class SithecContext : DbContext
    {
        public DbSet<Humano> Humanos { get; set; }
        
        public SithecContext(DbContextOptions<SithecContext> options) : base(options)
        {
        }

    }
}
