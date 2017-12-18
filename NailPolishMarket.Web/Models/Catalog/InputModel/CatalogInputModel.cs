using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NailPolishMarket.Web.Models.NailPolish.ViewModel;
using NailPolishMarket.Web.Mapping.Contracts;
using NailPolishMarket.Web.Models.NailPolish.InputModel;

namespace NailPolishMarket.Web.Models.Catalog.InputModel
{
    public class CatalogInputModel : IMapFrom<NailPolishMarket.Models.Catalog>
    {
        public CatalogInputModel()
        {
            NailPolishes = new List<NailPolishInputModel>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

       public DateTime Date { get; set; }

        public bool Selected { get; set; }

        public List<NailPolishInputModel> NailPolishes {get; set; }

    }
}