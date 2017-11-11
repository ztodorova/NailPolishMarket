using System.Data.Entity;
using NailPolishMarket.Models;
using System.Data.Entity.Infrastructure;

namespace NailPolishMarket.Data
{
    public interface INailPolishMarketDbContext
    {
        IDbSet<Catalog> Catalogs { get; set; }

        IDbSet<NailPolish> NailPolishes { get; set; }

        IDbSet<Order> Orders { get; set; }

        IDbSet<User> Users { get; set; }

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
}