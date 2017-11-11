namespace NailPolishMarket.Data.Migrations
{
    using Data;
    using Models;
    using FileReader;
    using Repositories;
    using System;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<NailPolishMarketDbContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "NailPolishMarket.Data.NailPolishMarketDbContext";
        }

        protected override void Seed(NailPolishMarketDbContext context)
        {
            var first = new NailPolish { Name = "FirstNailPolish", Price = 4.5M };
            var second = new NailPolish { Name = "SecondNailPolish", Price = 5.0M };

            var firstCatalog = new Catalog();
            firstCatalog.Name = "My First Catalog";
            firstCatalog.Date = DateTime.Now;
            firstCatalog.NailPolishes.Add(second);
            context.Catalogs.Add(firstCatalog);
            context.SaveChanges();

            var firstUser = new User { UserName = "First User" };

            var firstOrder = new Order { Date = DateTime.Now };
            //  firstOrder.NailPolishes.Add(second);
            //  firstOrder.User = firstUser;

            context.NailPolishes.Add(first);
            context.NailPolishes.Add(second);
            context.SaveChanges();

            context.Orders.Add(firstOrder);
            context.SaveChanges();




            var fileReader = new FileReader(@"E:\test.txt");
            var nailPolishes = fileReader.GetNailPolishes();
            fileReader.CloseFile();
            foreach (var item in nailPolishes)
            {
                context.NailPolishes.Add(item);
            }
            context.SaveChanges();


            // var userRepository = new EfRepository<User>();
            // userRepository.Add(new User { UserName = "FirstUser" });
            // userRepository.Add(new User { UserName = "SecondUser" });
            //
            // var orderRepository = new EfRepository<Order>();
            // orderRepository.Add(new Order { Date = DateTime.Now });


        }
    }
}
