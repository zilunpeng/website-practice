using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace fruitland.data
{
    public class FruitContext :DbContext
    {
        public FruitContext() :base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<FruitContext,FruitMigrationConfiguration>()
                );
        }

        public DbSet<Fruit> fruits { get; set; }
        public DbSet<Comment> comments { get; set; }

    }
}