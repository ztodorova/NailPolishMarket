using System;
using System.Collections.Generic;
using NailPolishMarket.Web.Models.NailPolish.ViewModel;
using NailPolishMarket.Web.Mapping.Contracts;
using NailPolishMarket.Models;
using AutoMapper;

namespace NailPolishMarket.Web.Models.Catalog.ViewModel
{
    public class CatalogViewModel : IMapFrom<NailPolishMarket.Models.Catalog>
    {
        private ICollection<NailPolishViewModel> nailPolishes;

        public CatalogViewModel()
        {
            this.nailPolishes = new HashSet<NailPolishViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public ICollection<NailPolishViewModel> NailPolishes
        {
            get { return this.nailPolishes; }
            set { this.nailPolishes = value; }
        }
    }
}