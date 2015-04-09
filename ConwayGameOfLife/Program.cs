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
            /*The following variables can be put as a parameter in the GameOfLifeBoard
             * at the bottom of this page (line 126). 
             * Feel free to mess around with the editor variable, adding live and dead
             * cells as you see fit, but all the other variables are common game of life
             * patterns, so please leave them be, just add them as a parameter and enjoy the show! */

            var editor = @"
oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
o----------------------------------------------------------------------o
o----------------------------------------------------------------------o
o-------#####------######----##------#--#######--#######--#------------o
o-------#----#----#------#---#-#-----#-----#-----#--------#------------o
o-------#-----#--#--------#--#--#----#-----#-----#--------#------------o
o-------#-----#--##########--#---#---#-----#-----#####----#------------o
o-------#-----#--#--------#--#----#--#-----#-----#--------#------------o
o-------#----#---#--------#--#-----#-#-----#-----#--------#------------o
o-------#####----#--------#--#------##--#######--#######--########-----o
o----------------------------------------------------------------------o
o----------------------------------------------------------------------o
oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo".Trim();

            var stills = @"
oooooooooooooooo
o--------------o
o-##----##-----o
o-##---#--#----o
o-------##-----o
o--------------o
o--##----------o
o-#--#---------o
o--#-#---------o
o---#---##-----o
o-------#-#----o
o--------#-----o
o--------------o
oooooooooooooooo".Trim();

            var oscillators = @"
ooooooooooooooooooooooooooooooooo
o-------------------------------o
o-------------------------------o
o----###-----------###---###----o
o-------------------------------o
o----------------#----#-#----#--o
o----------------#----#-#----#--o
o----###---------#----#-#----#--o
o---###------------###---###----o
o-------------------------------o
o------------------###---###----o
o----------------#----#-#----#--o
o----------------#----#-#----#--o
o------##--------#----#-#----#--o
o------##-----------------------o
o--------##--------###---###----o
o--------##---------------------o
o-------------------------------o
ooooooooooooooooooooooooooooooooo".Trim();

            var glider = @"
ooooooooooooooooooo
o---#-------------o
o-#-#-------------o
o--##-------------o
o-----------------o
o-----------------o
o-----------------o
o-----------------o
o-----------------o
o-----------------o
o-----------------o
o-----------------o
o-----------------o
ooooooooooooooooooo".Trim();

            var spaceship = @"
oooooooooooooooooooooooooooooooooooooooooo
o----------------------------------------o
o----------------------------------------o
o-#--#-----------------------------------o
o-----#----------------------------------o
o-#---#----------------------------------o
o--####----------------------------------o
o----------------------------------------o
o----------------------------------------o
oooooooooooooooooooooooooooooooooooooooooo".Trim();



            var gosperGliderGun = @"
oooooooooooooooooooooooooooooooooooooooo
o--------------------------------------o
o--------------------------------------o
o-------------------------#------------o
o-----------------------#-#------------o
o-------------##------##------------##-o
o------------#---#----##------------##-o
o-##--------#-----#---##---------------o
o-##--------#---#-##----#-#------------o
o-----------#-----#-------#------------o
o------------#---#---------------------o
o-------------##-----------------------o
o--------------------------------------o
o--------------------------------------o
o--------------------------------------o
o--------------------------------------o
o--------------------------------------o
o--------------------------------------o
o--------------------------------------o
o--------------------------------------o
oooooooooooooooooooooooooooooooooooooooo".Trim();

            var board = new GameOfLifeBoard(oscillators);

            while (true)
            {
                Console.Clear();
                var output = board.ToString();
                Console.Write(output);
                Thread.Sleep(100);
                board.NextGeneration();
            }
        }
    }
}