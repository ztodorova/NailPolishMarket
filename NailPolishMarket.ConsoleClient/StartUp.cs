namespace NailPolishMarket.ConsoleClient
{
    using System;
    using System.Linq;
    using Models;
    using Data;
    using System.Data.Entity;
    using Data.Migrations;
    using Data.Repositories;
    using Data.Data;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<NailPolishMarketDbContext,Configuration>());

            //      INailPolishMarketDbContext db = new NailPolishMarketDbContext();
            //
            //      db.Catalogs.Count();
            //
            //   var nailPolish = new NailPolish
            //   {
            //       Name = "Classic Nail Lacquer",
            //       Brand = "OPI",
            //       Price = 12.50M
            //   };
            //  
            //   db.NailPolishes.Add(nailPolish);
            //   db.SaveChanges();
            //  
            //   Console.WriteLine(db.NailPolishes.Count());

            var data = new NailPolishMarketData();

            var newNailPolish = new NailPolish();
            newNailPolish.Name = "New Nailpolish 1";
            data.NailPolishes.Add(newNailPolish);
            data.SaveChanges();


            var newCatalog = new Catalog();
            newCatalog.Name = "New Catalog 1";
            newCatalog.Date = DateTime.Now;
            data.Catalogs.Add(newCatalog);
            data.SaveChanges();
            
            var user = new User();
            data.Users.Add(user);
            data.SaveChanges();

            var order = new Order();
            order.Date = DateTime.Now;
            order.NailPolishes.Add(newNailPolish);
            data.Orders.Add(order);
            data.SaveChanges();




        }
    }
}
