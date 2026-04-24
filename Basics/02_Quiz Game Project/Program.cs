namespace _02_Quiz_Game_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Questions = new string[] { "1.What Is My Name?", "2.Bearth Year ?", "Month Of BirthDate:" };
            string[] Answers = new string[] { "Menna", "2004", "6" };
            Console.WriteLine("Welcome To Quiz");
            Console.WriteLine("--------------------------");
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(Questions[i]);
                    string Answer = Console.ReadLine();
                    CheckCorrectAnswer(Answer, Answers[i]);
                }
                Console.WriteLine("---------------Quiz Completed ----------");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void CheckCorrectAnswer(string Userinput,string Answer)
        {
            if(string.IsNullOrEmpty(Userinput))
            {
                throw new Exception("Answer Cant be Empty");
            }
            if (Userinput == Answer)
            {
                Console.WriteLine("Correct Answer");
            }
            else
            {
                Console.WriteLine($"Wrong Answer And The Right Answer Is {Answer}");
            }
        }
    }
}
