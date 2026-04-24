namespace _06_Shopping_Sys
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hey User!");
            Product_Manager product_Manager = new Product_Manager();
            while (true)
            {
                Console.WriteLine("Are You Employee(E) Or Customer(C)?");
                char UserType = Console.ReadLine().ToUpper()[0];
                switch (UserType)
                {
                    case 'E':
                        Employee employee = new Employee()
                        {
                            Emp_Id = 1,
                            Emp_Name = "Menna"
                        };
                        Console.WriteLine($"Hello {employee.Emp_Name} Your id {employee.Emp_Id}");
                        Console.WriteLine("===============================");

                        while (true)
                        {
                            Console.WriteLine("Which Service You Want?");
                            Console.WriteLine("==========================================");
                            product_Manager.viewList();
                            Console.WriteLine("==========================================");
                            Console.WriteLine("1.Add Product\t2.Remove Product\t3.Update Product\t4.Exit");
                            int Service = int.Parse(Console.ReadLine());
                            switch (Service)
                            {
                                case 1:
                                    Console.WriteLine("Enter Product Detail (id Name Price)");
                                    Console.Write("ID:");
                                    int productId = int.Parse(Console.ReadLine());
                                    Console.Write("Name:");
                                    string productName = Console.ReadLine();
                                    Console.WriteLine("Price:");
                                    double productPrice = double.Parse(Console.ReadLine());
                                    Product Item = new Product()
                                    {
                                        ID = productId,
                                        Name = productName,
                                        Price = productPrice
                                    };
                                    employee.AddProduct(Item, product_Manager);
                                    break;//Add product
                                case 2:
                                    Console.WriteLine("Enter Employee id to remove");
                                    int prodID = int.Parse(Console.ReadLine());
                                    employee.RemoveProduct(prodID, product_Manager);
                                    break;
                                case 3:
                                    Console.WriteLine("Which Product You Want To Edit?");
                                    int PID = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Which Value You want To Edit:\n1. Name Of Product\t2.Price");
                                    int ServiceToUpdate = int.Parse(Console.ReadLine());
                                    switch (ServiceToUpdate)
                                    {
                                        case 1:
                                            Console.WriteLine("What is New Value?");
                                            string NameOfNewValue = Console.ReadLine();
                                            employee.EditProductName(PID, NameOfNewValue, product_Manager);
                                            break;
                                        case 2:
                                            Console.WriteLine("What is New Value?");
                                            int IdOfNewValue = int.Parse(Console.ReadLine());
                                            employee.EditProducPrice(PID, IdOfNewValue, product_Manager);
                                            break;
                                        default:
                                            Console.WriteLine("Wrong Number ");
                                            break;
                                    }
                                    break;
                                case 4:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Enter A Write Number");
                                    break;
                            }
                        }
                        break;
                    case 'C':
                        Customer customer = new Customer();
                        Cart cart = new Cart();
                        Console.WriteLine("Hello Customer");
                            List<Product> products = new List<Product>();
                            products.Add(new Product() { ID = 1, Name = "P1", Price = 1000 });
                            products.Add(new Product() { ID = 2, Name = "P2", Price = 5000 });
                            products.Add(new Product() { ID = 3, Name = "P3", Price = 10500 });
                            products.Add(new Product() { ID =4, Name = "P4", Price = 10004 });
                            products.Add(new Product() { ID = 5, Name = "P5", Price = 1400 });
                        while (true)
                        {
                            Console.WriteLine("==============================");
                            Console.WriteLine("Which Service You Need ");
                            Console.WriteLine("1.Add Product To Cart\t2.Remove From Cart\n3.View Cart\t4.Exit");
                            Console.WriteLine("==============================");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    foreach (var item in products)
                                    {
                                        Console.WriteLine($"Product ID:{item.ID} ,Product Name{item.Name},Product Price{item.Price}");
                                    }
                                    Console.WriteLine("Which Id Product You Want To Buy:");
                                    int prodId=int.Parse(Console.ReadLine());
                                    Product producttoAdd=products.Find(Product => Product.ID == prodId);
                                    customer.AddingToCart(producttoAdd, cart);
                                    break;
                                case 2:
                                    cart.ShowCart();
                                    Console.WriteLine("Which Product You Want To Remove:");
                                    int RemovedprodId = int.Parse(Console.ReadLine());
                                    Product Removed = cart.GetItemfromlist(RemovedprodId-1);
                                    customer.RemovingFromCart(Removed,cart);
                                    cart.ShowCart();
                                    break;
                                case 3:
                                    cart.ShowCart();

                                    break;
                                case 4:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Enter Write Number ");
                                    break;
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Enter Correct Choice(E OR C)");
                        break;
                }

            }

        }
    }
}
