using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace fruitland.data
{
    public class FruitMigrationConfiguration
        : DbMigrationsConfiguration<FruitContext>
    {
        public FruitMigrationConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FruitContext context)
        {
            base.Seed(context);
        }
    }
}
