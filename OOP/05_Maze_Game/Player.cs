using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Maze_Game
{
    internal class Player : IMazeObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char icon =>'@';

        public bool IsSolid => true;
    }
}
