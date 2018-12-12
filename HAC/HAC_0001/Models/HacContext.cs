using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace HAC.Models
{
    public class HacContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Hac.db");
        }
    }
}
