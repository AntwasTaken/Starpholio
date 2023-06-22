using Microsoft.EntityFrameworkCore;
using Starpholio.Models;

namespace Starpholio.Data
{
    public class StarpholioDB : DbContext
    {
        public DbSet<LoginSys> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your database schema here
            modelBuilder.Entity<LoginSys>().ToTable("Users");
        }
    }
}
