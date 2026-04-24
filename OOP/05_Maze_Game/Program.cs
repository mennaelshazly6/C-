namespace _05_Maze_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Maze");
            Console.WriteLine("Use Arows To Move Plyer");
            Maze newmaze=new Maze(40, 20);
            while (true)
            {
                newmaze.Draw();
                newmaze.MovePlayer();
            }
        }
    }
}
