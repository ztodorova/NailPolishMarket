using NailPolishMarket.Models;
using NailPolishMarket.Services.NailPolishes;
using NailPolishMarket.Web.Models.NailPolish.InputModel;
using NailPolishMarket.Web.Models.NailPolish.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NailPolishMarket.Web.Controllers
{
    public class NailPolishController : Controller
    {
        private readonly INailPolishesService nailPolishesService;

        public NailPolishController(INailPolishesService nailpolishesService)
        {
            this.nailPolishesService = nailpolishesService;
        }

        // GET: NailPolish
        public ActionResult Index()
        {
            var nailPolishesViewModels = new List<NailPolishViewModel>();
            var nailPolishesData = nailPolishesService.GetAll();
            nailPolishesViewModels = AutoMapper.Mapper.Map<List<NailPolishViewModel>>(nailPolishesData);

            return View(nailPolishesViewModels);
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

        [HttpPost]
        public ActionResult CreateNailPolish(NailPolishInputModel model)
        {
            var nailPolish = AutoMapper.Mapper.Map<NailPolish>(model);
            this.nailPolishesService.CreateNailPolish(nailPolish);
            return View();
        }


        [HttpGet]
        public ActionResult ReturnNailPolish(int id)
        {
            var nailPolish = nailPolishesService.GetNailPolishById(id);
            var nailPolishViewModel = AutoMapper.Mapper.Map<NailPolishViewModel>(nailPolish);

            return View(nailPolishViewModel);
        }
    }
}