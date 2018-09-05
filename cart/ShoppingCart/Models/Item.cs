using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class Item
    {
        public int Quantity { set; get; }
        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; } 
    }
}