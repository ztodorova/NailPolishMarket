namespace NailPolishMarket.Data
{
    using Migrations;
    using Models;
    using System.Data.Entity;
    using System;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class NailPolishMarketDbContext : IdentityDbContext<User>, INailPolishMarketDbContext
    {
        public NailPolishMarketDbContext()
            : base("NailPolishMarketDatabase")
        {
            var migration = new MigrateDatabaseToLatestVersion<NailPolishMarketDbContext, Configuration>();
            Database.SetInitializer(migration);
        }

        public virtual IDbSet<Catalog> Catalogs { get; set; }

        public virtual IDbSet<NailPolish> NailPolishes { get; set; }

        public virtual IDbSet<Order> Orders { get; set; }

        public static NailPolishMarketDbContext Create()
        {
            return new NailPolishMarketDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>()
            where TEntity : class
        {
            return base.Set<TEntity>();
        }

    }
}


