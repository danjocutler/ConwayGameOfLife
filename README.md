Game Of Life
============
A console app in c# that implements Conway's Game of Life Rules and outputs to a
console screen.


Rules
-----
In a grid, cells either live, or die, based on the following:-
  * Any live cell with fewer than two live neighbours dies, as if caused by under-population.
  * Any live cell with two or three live neighbours lives on to the next generation.
  * Any live cell with more than three live neighbours dies, as if by overcrowding.
  * Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

A neighbour is any cell occupying the current cell's 8 adjacent squares in the grid.

Tech
-----

 * C#
 * NUnit for TDD
 * Visual Studio Community 2013

 How To Use
 -----------
 Clone this Repo and open in Visual Studio. Press f5 to compile.
 You can run the tests in NUnit.

 Issues/challenges/interesting points
 ------------------------
 At the moment, I am having an issue with the board getting index and argument
 OutOfRangeExceptions. I believe this comes from the cells around the edge of the board
 trying to find neighbours that aren't there. I'm still trying to find a way
 to remedy this.

 I enjoyed using the StringBuilder to create the board, and actually visually
 create a board that could be rendered and seen on the screen. This made manually creating
 boards easier, and I have made a number of typical 'life' pattern examples because of this.
 It was interesting to use this way as a testing technique as well, as one can actually see the
 'before' and 'after' state of the board expected, although I question its readability on bigger
 projects as it does get rather repetitive after a while.

 I've found the IntelliSense of Visual Studio a great tool to see and experiment with various
 methods available to me in certain situations, although I won't let it make me a 'lazy coder' which
 is a risk I think many could fall into.
