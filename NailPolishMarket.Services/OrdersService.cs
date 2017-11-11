using NailPolishMarket.Data.Repositories;
using NailPolishMarket.Models;
using NailPolishMarket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NailPolishMarket.Data.Data;

namespace NailPolishMarket.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly  INailPolishMarketData data;

        public OrdersService(INailPolishMarketData data)
        {
            this.data = data;
        }

        public IQueryable<Order> GetAll()
        {
            var result = this.data.Orders.All();
            return result;
        }

       // public void CreateOrder(OrderInputModel)

    }
}
