namespace NailPolishMarket.Data.Data
{
    using System;
    using System.Collections.Generic;
    using Repositories;
    using Models;

    public class NailPolishMarketData : INailPolishMarketData
    {
        private INailPolishMarketDbContext context;

        private readonly IDictionary<Type, object> repositories;

        public NailPolishMarketData()
        {
            this.context = new NailPolishMarketDbContext();
            this.repositories = new Dictionary<Type, object>();
        }
        public INailPolishMarketDbContext Context
        {
            get
            {
                return this.context;
            }
        }
       
        public IRepository<Catalog> Catalogs
        {
            get { return this.GetRepository<Catalog>(); }
        }

        public IRepository<NailPolish> NailPolishes
        {
            get
            {
                return this.GetRepository<NailPolish>();
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                return this.GetRepository<Order>();
            }
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(EfRepository<T>);

                var newRepo = Activator.CreateInstance(type, this.context);
                this.repositories.Add(typeof(T), newRepo);
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
