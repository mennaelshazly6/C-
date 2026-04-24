namespace _04_Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello To Our Library");
            Library L1 = new Library();
            Console.WriteLine("=============================");
            Console.WriteLine("Are You Librian (L) or Regular User(R)? ");
            char TypeOfUser = Console.ReadLine().ToUpper()[0];
            Console.WriteLine("Enter Your Name:");
            string NameUser = Console.ReadLine();
            switch (TypeOfUser)
            {            
                case 'L':
                    Librian lib1 = new Librian(NameUser);
                    Console.WriteLine($"Hello {lib1.Name}");
                    while (true)
                    {
                        Console.WriteLine("Wich Service Do You Need ?\n1.Add\t 2.Remove\t 3.Display\t 4.Exit");
                        int Service = int.Parse(Console.ReadLine());
                        switch (Service)
                        {
                            case 1:
                                Console.Write("Enter a Book Name:");
                                string BookName = Console.ReadLine();
                                Console.Write("Enter a Book Author:");
                                string BookAuthor = Console.ReadLine();
                                Console.Write("Enter a Book Year:");
                                int BookYear = int.Parse(Console.ReadLine());
                                Book newBook = new Book()
                                {
                                    Title = BookName,
                                    Author = BookAuthor,
                                    Year = BookYear,
                                };
                                lib1.AddBook(newBook, L1);
                                Console.WriteLine("Book Added Successfully");
                                Console.WriteLine("====================================");
                                break;
                            case 2:
                                Console.Write("Enter a Book Name to Remove:");
                                BookName = Console.ReadLine();

                                lib1.RemoveBook(BookName, L1);
                                break;
                            case 3:
                                lib1.Display(L1);
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Error Enter A write Choice");
                                break;

                        }
                    }

                    break;

                case 'R':
                    Regular_User R1 = new Regular_User()
                    {
                        Name = NameUser,
                    };
                    Console.WriteLine($"Hello Regular User{R1.Name}");
                    while (true)
                    {
                        Console.WriteLine("Which Service you Want\n 1.Display All Books\t 2.Borrow Books ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                R1.Display(L1);
                                break;
                            case 2:
                                Console.WriteLine("Which Book You Want To Borrow:");
                                string BookName = Console.ReadLine();
                                R1.BorrowBook(BookName, L1);
                                break;
                            default:
                                Console.WriteLine("Please Enter A write CHoice0");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine($"Enter A Corect Choice");
                    break;
                }
            }
        }
        
    
}
