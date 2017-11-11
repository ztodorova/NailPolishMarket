using System.Linq;
using NailPolishMarket.Models;

namespace NailPolishMarket.Services
{
   public interface ICatalogsService
    {
        IQueryable<Catalog> GetAll();

        Catalog GetCatalogById(int id);
    }
}