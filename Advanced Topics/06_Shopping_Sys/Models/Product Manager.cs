namespace _06_Shopping_Sys
{
    internal class Product_Manager
    {
        List<Product> Items = new List<Product>();
        public void AddItem(Product newp)
        {
            Items.Add(newp);
            Console.WriteLine("Product Added Successfully");
        }
        public void RemoveItem(int id)
        {
            foreach (var item in Items)
            {
                if (item.ID == id && item != null)
                {
                    Items.Remove(item);
                    Console.Write("Removed Successfully");
                    return;
                }

            }
            Console.WriteLine("Item Not Found");
        }
        public void EditIName(int Pid, string newvalue)
        {
            foreach (var item in Items)
            {
                if (item.ID == Pid && item != null)
                {
                    item.Name = newvalue;
                    Console.WriteLine("Name Changed Sucessfully");
                    return;
                }
            }
            Console.WriteLine("Product Not Found");
        }
        public void EditItemPrice(int Pid, int newvalue)
        {
            foreach (var item in Items)
            {
                if (item.ID == Pid && item != null)
                {
                    item.Price = newvalue;
                    Console.WriteLine("price Changed Sucessfully");
                    return;
                }
            }
            Console.WriteLine("Product Not Found");
        }
        public void viewList()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"ID:{item.ID}  ,Name:{item.Name},  price:{item.Price}");
            }
        }
        public Product GetProductFromList(int Prod_ID)
        {
            var item=Items.Find(p=>p.ID==Prod_ID);
            return item;
        }

    }
}
