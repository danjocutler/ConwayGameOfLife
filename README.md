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
