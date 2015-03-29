using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwayGameOfLife
{
    class GameOfLifeBoard
    {
        private List<string> _board;

        public int Width { get { return _board.Max(width => width.Length); } }
        public int Height { get { return _board.Count; } }

        public GameOfLifeBoard(string board)
        {
            _board = board.Split(new [] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }


    }
}
