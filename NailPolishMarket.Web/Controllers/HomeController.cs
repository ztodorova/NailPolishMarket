using NailPolishMarket.Services;
using NailPolishMarket.Web.Models;
using NailPolishMarket.Web.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NailPolishMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrdersService ordersService;

        public HomeController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        public ActionResult Index()
        {
            var orders = this.ordersService.GetAll()
                .Select(x => new OrdersViewModel()
                {
                    Date = x.Date
                })
                .ToList();

            var viewModel = new HomeViewModel()
            {
                Orders = orders,
            };

            return View(viewModel);
        }

     

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}