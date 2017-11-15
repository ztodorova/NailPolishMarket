using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NailPolishMarket.Web.Models.NailPolish.ViewModel;
using NailPolishMarket.Web.Mapping.Contracts;

namespace NailPolishMarket.Web.Models.Catalog.InputModel
{
    public class CatalogInputModel : IMapFrom<NailPolishMarket.Models.Catalog>
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public ICollection<NailPolishViewModel> NailPolishes;
    }
}