using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Shopping_Sys
{
    internal class Cart
    {
        List<Product> products=new List<Product>();
        public void AddItem(Product product)
        {
            
            products.Add(product);
            Console.WriteLine("Item Added Sucessfully");
        }
        public void RemoveItem(Product product)
        {
            products.Remove(product);
        }
        public void ShowCart()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Product Name: {item.Name}  product Price{item.Price}");
            }
        }
        public Product GetItemfromlist(int Prod_ID)
        {
            var item= products[Prod_ID];
            return item;
        }
    }
}
