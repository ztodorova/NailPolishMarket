namespace NailPolishMarket.Data.Data
{
    using Models;
    using Repositories;

    public interface INailPolishMarketData
    {
       INailPolishMarketDbContext Context { get; }

        IRepository<Catalog> Catalogs { get; }

        IRepository<NailPolish> NailPolishes { get; }

        IRepository<Order> Orders { get; }

        IRepository<User> Users { get; }

        int SaveChanges();
    }
}
