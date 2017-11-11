using System.Linq;
using NailPolishMarket.Models;

namespace NailPolishMarket.Services
{
    public interface IOrdersService
    {
        IQueryable<Order> GetAll();
    }
}