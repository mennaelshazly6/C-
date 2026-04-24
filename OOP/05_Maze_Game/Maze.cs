using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Maze_Game
{
    public class Maze
    {
        private int _Width;
        private int _Height;
        private Player _player;
        private IMazeObject[,] _MazeObjectArray;
        public Maze(int W, int H)
        {
            _Width = W;
            _Height = H;
            _MazeObjectArray=new IMazeObject[W, H];
            _player = new Player()
            {
                X = 1,
                Y = 1
            };
        }
        public void Draw()
        {
            Console.Clear();
            for(int y = 0; y < _Height; y++)
            {
                for(int x = 0; x < _Width; x++)
                {
                    if (x==39&&y==39)
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].icon);
                    }
                    else if (x == _player.X && y == _player.Y)
                    {
                        
                        Console.Write(_player.icon);
                    }
                    else if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].icon);
                    }
                    else if (x%3==0&&y%3==0)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].icon);
                    }
                    else
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].icon);
                    }
                    
                }
                Console.WriteLine();
            }
        }
        public void MovePlayer()
        {
            ConsoleKeyInfo UserInput = Console.ReadKey();
            ConsoleKey key = UserInput.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0,- 1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
            }
        }
        public void UpdatePlayer(int dx,int dy)
        {
            int newx=_player.X + dx;
            int newy=_player.Y + dy;
            if (newx < _Width && newx >=0&& newy< _Height && newy >= 0 && _MazeObjectArray[newx,newy].IsSolid==false)
            {
                _player.X = newx;
                _player.Y =newy;
                 Draw();
            }
           
        }
    }
}
