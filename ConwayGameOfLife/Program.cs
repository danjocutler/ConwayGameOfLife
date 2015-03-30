using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = @"
---##-#-#-###-#
##--##----#-##-
##----###-##---
--####-#-#-#-##
---###---##-###
---###-#--#---#
---####---##--#
".Trim();

            var board = new GameOfLifeBoard(creator);

            for (int i = 0; i < 101; i++)
            {
                Console.Clear();
                var output = board.ToString();
                Console.Write(output);
                board.NextGeneration();
            }
        }
    }
}