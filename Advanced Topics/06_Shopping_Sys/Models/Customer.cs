using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Shopping_Sys
{
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void AddingToCart(Product product,Cart cart)
        {
            cart.AddItem(product);
        }
        public void RemovingFromCart(Product product, Cart cart)
        {
            cart.RemoveItem(product);
        }
    }
}
