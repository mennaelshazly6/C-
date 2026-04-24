using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Maze_Game
{
    internal class EmptySpace : IMazeObject
    {
        public char icon => ' ';

        public bool IsSolid =>false;
    }
}
