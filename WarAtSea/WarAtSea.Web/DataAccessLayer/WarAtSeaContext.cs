using WarAtSea.Web.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WarAtSea.Web.DataAccessLayer
{
    public class WarAtSeaContext : DbContext
    {
        /* The name of the connection string (stored in the Web.config file) OR the connection string
         * itself is passed as a parameter to the base constructor. If you don't specify a connection
         * string, or the name of one explicitly, EF assumes the connection string name is the same as
         * the class name (which in this case is the same thing). */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public WarAtSeaContext() : base("WarAtSeaContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
