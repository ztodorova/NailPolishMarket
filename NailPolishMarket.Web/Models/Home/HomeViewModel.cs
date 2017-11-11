using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NailPolishMarket.Web.Models.Home
{
    public class HomeViewModel
    {
        public ICollection<OrdersViewModel> Orders { get; set; }

    }
}