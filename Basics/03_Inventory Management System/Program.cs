namespace _03_Inventory_Management_System
{
    internal class Program
    {
        static string[,] innventory = new string[50, 3];
        static int productcount = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To your inventory System ");
            Console.WriteLine("===========================================");
            while (true)
            {
                Console.WriteLine("Choose \n" +
                    "1.Add Product\t 2.Update Product\n3.View Products\t 4.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        //Add product
                        AddProduct();
                        break;
                    case 2:
                        //Update Product
                        UpdateProduct();
                        break;
                    case 3:
                        //view Product
                        ViewProduct();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

            }
        }
        private static void AddProduct()
        {
            
            Console.WriteLine("Enter a Product Name:");
            string ProductName=Console.ReadLine();
            Console.WriteLine("Enter a Product Quantity:");
            string ProductQuantity = Console.ReadLine();
            Console.WriteLine("Enter a Product Price:");
            string ProductPrice = Console.ReadLine();
            innventory[productcount, 0] = ProductName;
            innventory[productcount, 1] = ProductQuantity;
            innventory[productcount, 2] = ProductPrice;
            productcount++;
            Console.WriteLine("Product Added Successfuly");
            Console.WriteLine("====================================");

        }
        private static void UpdateProduct()
        {
            Console.WriteLine("Enter Product Id To Update");
            int ProductId=int.Parse(Console.ReadLine());
            Console.WriteLine("0.Name\t 1.Quantity\t2.Price");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Value");
            string value = Console.ReadLine();
            innventory[ProductId , choice] = value;

        }
        private static void ViewProduct()
        {
            for (int i=0;i<productcount;i++)
            {
                    Console.WriteLine($"Product ID:{i} Product Name:{innventory[i, 0]} Product Quantity:{innventory[i,1]} Product Price:{innventory[i, 2]}");
        }   }
    }
}
