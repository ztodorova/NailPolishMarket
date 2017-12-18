using NailPolishMarket.Web.Mapping.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NailPolishMarket.Web.Models.NailPolish.InputModel
{
    public class NailPolishInputModel : IMapFrom<NailPolishMarket.Models.NailPolish>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Selected { get; set; }

      //  public string Brand { get; set; }

      //  public decimal Price { get; set; }
    }
}