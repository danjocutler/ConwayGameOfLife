using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    class GameOfLifeBoard
    {
        private List<string> _board;

        public int Width { get { return _board.Max(height => height.Length); } }
        public int Height { get { return _board.Count; } }

        public GameOfLifeBoard(string board)
        {
            _board = board.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var row in _board)
            {
                builder.AppendLine(row);
            }
            return builder.ToString().Trim();
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
                try
                {
                    var neighbour = _board[set.X][set.Y];
                    neighbours.Add(neighbour);
                }
                catch { }
            }
            return neighbours;
        }

        public void NextGeneration()
        {
            var nextGen = new List<string>();

            for (var x = 0; x < Width; x++)
            {
                var row = "";
                for (var y = 0; y < Height; y++)
                {
                    var change = Rules(x, y);
                    row += change;
                }
                nextGen.Add(row);
            }
            _board = nextGen;
        }

        private object Rules(int x,int y)
        {
 	        var cell = _board[x][y];
            var neighbours = Neighbours(x, y).ToList();

            if (cell == '#')
            {
                if (neighbours.Count(neighbour => neighbour == '#') < 2
                    || neighbours.Count(neighbour => neighbour == '#') > 3)
                {
                    return '-';
                }
                else
                {
                    return '#';
                }
            }
            else if (cell == '-')
            {
                if (neighbours.Count(neighbour => neighbour == '#') == 3)
                {
                    return '#';
                }         
            }
            return cell;
        }        
    }
}
