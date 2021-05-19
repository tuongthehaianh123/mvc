using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopWebMVC.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}