using NailPolishMarket.Data.Data;
using NailPolishMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailPolishMarket.Services
{
    public class CatalogsService : ICatalogsService
    {
        private readonly INailPolishMarketData data;

        public CatalogsService(INailPolishMarketData data)
        {
            this.data = data;
        }

        public IQueryable<Catalog> GetAll()
        {
            var result = this.data.Catalogs.All();
            return result;
        }

        public Catalog GetCatalogById(int id)
        {
            var result = this.data.Catalogs.All().FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
