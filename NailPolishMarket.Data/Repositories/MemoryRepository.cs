﻿using NailPolishMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailPolishMarket.Data.Repositories
{
    public class MemoryRepository<TEntity> : IRepository<TEntity>
    {
        private readonly ICollection<TEntity> data;

        public MemoryRepository()
        {
            this.data = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this.data.Add(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.data.AsQueryable();
        }

        public TEntity FindById(object id)
        {
            return this.data.FirstOrDefault();
        }

        public void Remove(TEntity entity)
        {
            this.data.Remove(entity);
        }

        public void SaveChanges()
        {
        }

        public void Update(TEntity Entity)
        {
        }
    }
}
