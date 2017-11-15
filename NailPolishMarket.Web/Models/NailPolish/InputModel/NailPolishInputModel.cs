using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NailPolishMarket.Web.Models.NailPolish.InputModel
{
    public class NailPolishInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }
    }
}