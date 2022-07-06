using Microsoft.EntityFrameworkCore;
using Rentocam.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentocam.Infra.Contexts
{
    public class RentocamContext : DbContext
    {
        public DbSet<CameraDetails> CameraDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=rentocam.db");
        }
    }
}
