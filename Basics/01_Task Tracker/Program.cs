namespace _01_Task_Tracker
{
    internal class Program
    {
        static string[] Tasks = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {
            //1. Add Task
            //2. View Tasks
            //3. Mark As Completed
            //4. Remove Task
            //5. Exit
            Console.WriteLine("Welcome To Task Tracker ");
            Console.WriteLine("=========================================");
            while (true)
            {
                Console.WriteLine("Choice Number From 1 to 5 :");
                Console.WriteLine("1.Add Task \t 2.View All Tasks\n3. Mark As Completed \t 4.Remove Task\n 5.Exit ");
                string UserChoice =Console.ReadLine();
                Console.WriteLine("=========================================");

                switch (UserChoice)
                {
                    case "1":
                        //Add Task
                        AddTask();
                        Console.WriteLine("=========================================");
                        break;
                    case "2":
                        //View All Tasks
                        ViewAllTasks();
                        Console.WriteLine("=========================================");
                        break;
                    case "3":
                        //Mark As Completed
                        MarkAsCompleted();
                        Console.WriteLine("=========================================");
                        break;
                    case "4":
                        //remove Task
                        RemoveTask();
                        Console.WriteLine("=========================================");
                        break;
                    case"5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Number From 1 to 5 Only");
                        Console.WriteLine("=========================================");
                        break;
                }
            }
        }
        static void AddTask()
        {
            Console.Write("Enter TaskTo Add:");
            Tasks[TaskIndex]= Console.ReadLine();
            TaskIndex++;
            Console.WriteLine("Task Added Successfully");
        }
        static void ViewAllTasks()
        {
            Console.WriteLine("Task List Is:");
            for (int i=0; i<TaskIndex;i++)
            {
                Console.WriteLine($"{i + 1}.{Tasks[i]}");
            }
        }
        static void MarkAsCompleted()
        {
            Console.WriteLine("Which Task U Want To Mark");
            int CompletedTask = int.Parse(Console.ReadLine());
            Tasks[CompletedTask-1] = Tasks[CompletedTask-1] + "____COMPLETED____";
            Console.WriteLine("Done");
        }
        static void RemoveTask()
        {
            Console.WriteLine("Enter Task Number To remove: ");
            int RemovedTask=int.Parse(Console.ReadLine());
            Tasks[RemovedTask-1] = "";
            Console.WriteLine("Removed Successfully");
        }
    }
}
