using NailPolishMarket.Web.Models.Catalog.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NailPolishMarket.Services;
using NailPolishMarket.Web.Models.Catalog.ViewModel;
using NailPolishMarket.Web.Models.NailPolish.ViewModel;

namespace NailPolishMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ICatalogsService catalogsService;

        public CatalogController(ICatalogsService catalogsService)
        {
            this.catalogsService = catalogsService;
        }

        // GET: Catalog
        public ActionResult Index()
        {
            var catalogs = new List<CatalogViewModel>();
            var catalogsData = catalogsService.GetAll();


            foreach (var catalog in catalogsData)
                {
                    catalogs.Add(new CatalogViewModel
                    {
                        Id = catalog.Id,
                        Name = catalog.Name,
                        Date = catalog.Date,
                    });
                }
            
            return View(catalogs);
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Creating a catalog.";
            return View();
        }

        [HttpPost]
        public ActionResult Create(CatalogInputModel model)
        {
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