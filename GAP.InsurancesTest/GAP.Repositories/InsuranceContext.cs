using GAP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {

        }
        
        public DbSet<Client> Client { get; set; }
        public DbSet<CoveringType> CoveringType { get; set; }
        public DbSet<RiskType> RyskType { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        

    }
}
