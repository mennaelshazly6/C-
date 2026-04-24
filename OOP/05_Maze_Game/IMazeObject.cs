using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Maze_Game
{
    internal interface IMazeObject
    {
        public char icon { get;  }
        public bool IsSolid { get; }
    }
}
