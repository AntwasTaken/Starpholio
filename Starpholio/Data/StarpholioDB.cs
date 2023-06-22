using System.Data.Entity;

namespace Starpholio.Data
{
    public class StarpholioDB : DbContext
    {
        // DbSet properties and other configurations

        public StarpholioDB() : base("name=YourConnectionStringName")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure your database schema here
        }
    }
}
