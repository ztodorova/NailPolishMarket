using NailPolishMarket.Web.Models.Catalog.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NailPolishMarket.Services;
using NailPolishMarket.Web.Models.Catalog.ViewModel;
using NailPolishMarket.Web.Models.NailPolish.ViewModel;
using NailPolishMarket.Services.NailPolishes;
using NailPolishMarket.Models;
using NailPolishMarket.Web.Models.NailPolish.InputModel;

namespace NailPolishMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogsService catalogsService;
        private readonly INailPolishesService nailPolishesService;

        public CatalogController(ICatalogsService catalogsService, INailPolishesService nailpolishesService)
        {
            this.catalogsService = catalogsService;
            this.nailPolishesService = nailpolishesService;
        }

        // GET: Catalog
        public ActionResult Index()
        {
            var catalogsViewModels = new List<CatalogViewModel>();
            var catalogsData = catalogsService.GetAll();
            catalogsViewModels = AutoMapper.Mapper.Map<List<CatalogViewModel>>(catalogsData);

            return View(catalogsViewModels);
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Creating a catalog.";
            var nailPolishesData = nailPolishesService.GetAll();
            var nailPolishesInputModels = new List<NailPolishInputModel>();
            nailPolishesInputModels = AutoMapper.Mapper.Map<List<NailPolishInputModel>>(nailPolishesData);
            return View(nailPolishesInputModels);
        }

        [HttpPost]
        public ActionResult CreateCatalog(CatalogInputModel model)
        {
            var catalog = AutoMapper.Mapper.Map<Catalog>(model);
            catalog.Date = DateTime.Now;
            catalogsService.CreateCatalog(catalog);
            return View();
        }

        [HttpGet]
        public ActionResult ReturnCatalog(int id)
        {
            
            var catalog = catalogsService.GetCatalogById(id);
            var catalogViewModel = AutoMapper.Mapper.Map<CatalogViewModel>(catalog);

            return View(catalogViewModel);
        }
    }
}