using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    public class GameOfLifeBoard
    {
        private List<string> _board;

        public int Width { get { return _board.Max(line => line.Length); } }
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

        private bool CurrentCell(int i, int j)
        {
            return i == 0 && j == 0;
        }

        private char Dead()
        {
            return '-';
        }

        private char Alive()
        {
            return '#';
        }

        public List<char> Neighbours(int x, int y)
        {
            var cell = _board[x][y];
            var neighbours = new List<char>(8);
            if (cell != 'o')
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {                       
                        if (CurrentCell(i, j) == false)
                        {
                            try
                            {
                                var neighbour = _board[x + i][y + j];
                                neighbours.Add(neighbour);
                            }
                            catch 
                            {
                            }
                        }
                    }
                }
            }
            return neighbours;
        }

        public void NextGeneration()
        {
            var nextGen = new List<string>();

            for (var x = 0; x < Height; x++)
            {
                var row = "";
                for (var y = 0; y < Width; y++)
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
            var aliveNeighboursCount = neighbours.Count(state => state == '#');

            if (cell == Dead() && aliveNeighboursCount == 3)
            {
                return Alive();
            }
            else if (cell == Alive())
            {
                if (aliveNeighboursCount < 2 || aliveNeighboursCount > 3)
                {
                    return Dead();
                }
                return Alive();
            }
            return cell;
        }        
    }
}
