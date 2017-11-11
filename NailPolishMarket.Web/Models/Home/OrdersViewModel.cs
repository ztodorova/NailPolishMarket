using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NailPolishMarket.Web.Models.Home
{
    public class OrdersViewModel
    {
        [DisplayFormat(DataFormatString= "{0:dd/MM/yyy}")]
        public DateTime Date { get; set; }  
    }
}