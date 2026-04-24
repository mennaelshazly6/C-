using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Maze_Game
{
    internal class Wall : IMazeObject
    {
        public char icon => '#';

        public bool IsSolid => true;
    }
}
