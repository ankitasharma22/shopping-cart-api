using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class Cart : ICart
    {
        public int CardID() { throw new NotImplementedException(); }
        public bool AddItemToCart(Item newItemInCart)
        { 
            throw new NotImplementedException();
        }
         
        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public void DisplayCartItems()
        {
            throw new NotImplementedException();
        }

        public bool RemoveItemFromCart(Item removeItemFromCart)
        {
            throw new NotImplementedException();
        } 

    }

}