using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using ZooApp.Models;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace ZooApp.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZooApp.Models.ZooContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZooApp.Models.ZooContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.\

            context.Animals.Add(new Animal() { Food = "Meat", Name = "Tiger", Origin = "Sundorbon", Quantity = 20 });
            context.SaveChanges();


        }
    }
}


// Enable-Migrations -Verbose


// Add-Migration "InitialCreate" -Verbose
//public DbSet<Animal> Animals { get; set; }
// Add-Migration "InitialCreate" -Verbose
// Update - Database - Verbose

//context.Animals.Add(new Animal() { Food = "Meat", Name = "Tiger", Origin = "Sundorbon", Quantity = 20 });
//context.SaveChanges();

// Update - Database - Verbose
