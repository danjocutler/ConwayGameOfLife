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

        public IEnumerable<char> Neighbours(int x, int y)
        {
            var location = new List<Coordinates>
            {
                new Coordinates(x - 1, y - 1),
                new Coordinates(x - 1, y),
                new Coordinates(x - 1, y + 1),

                new Coordinates(x, y - 1),
                new Coordinates(x, y + 1),

                new Coordinates(x + 1, y - 1),
                new Coordinates(x + 1, y),
                new Coordinates(x + 1, y + 1)
            };

            var neighbours = new List<char>();
            foreach (var set in location)
            {
                var neighbour = _board[set.X][set.Y];
                neighbours.Add(neighbour);
            }
            return neighbours;
        }


    }
}
