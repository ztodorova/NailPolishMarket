using NailPolishMarket.Web.Models.NailPolish.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NailPolishMarket.Web.Controllers
{
    public class NailPolishController : Controller
    {
        // GET: NailPolish
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(NailPolishInputModel model)
        {
            return View();
        }
    }
}