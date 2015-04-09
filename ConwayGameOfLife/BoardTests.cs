using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ConwayGameOfLife
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void Board_Given2x2Board_CreatesBoard()
        {
            var board = new GameOfLifeBoard(@"
##
##".Trim());

            Assert.That(board.Width, Is.EqualTo(2));
            Assert.That(board.Height, Is.EqualTo(2));

        }

        [Test]
        public void Board_Given5x5Board_CreatesBoard()
        {
            var board = new GameOfLifeBoard(@"
#####
#####
#####
#####
#####".Trim());

            Assert.That(board.Width, Is.EqualTo(5));
            Assert.That(board.Height, Is.EqualTo(5));
        }

        [Test]
        public void CellOnBoard_Surrounded_Has8Neighbours()
        {
            var board = new GameOfLifeBoard(@"
ABC
DEF
GHI".Trim());

            Assert.That(board.Neighbours(1, 1).Count(), Is.EqualTo(8));
            // Assert.That(board.Neighbours(1, 1), Is.EqualTo('A', 'B', 'C', 'D', 'F', 'G', 'H', 'I'));
        }

        [Test]
        public void CellOnBoard_OnTheEdge_HasFiveNeighbours()
        {
            var board = new GameOfLifeBoard(@"
ABC
DEF
GHI".Trim());

            Assert.That(board.Neighbours(0, 1).Count(), Is.EqualTo(5));
        }

        [Test]
        public void CellOnBoard_OnTheCorner_HasThreeNeighbours()
        {
            var board = new GameOfLifeBoard(@"
ABC
DEF
GHI".Trim());

            Assert.That(board.Neighbours(0, 0).Count(), Is.EqualTo(3));
        }
    }

    [TestFixture]
    public class RulesTests
    {

        [Test]
        public void NextGeneration_AliveCellWith0Or1Neighbour_Dies()
        {
            // '#' == Alive
            // '-' == Dead
            var board = new GameOfLifeBoard(@"
---
##-
---".Trim());

            var result = @"
---
---
---".Trim();
            board.NextGeneration();

            Assert.That(board.ToString(), Is.EqualTo(result));
        }
       
        [Test]
        public void NextGeneration_AliveCellWith4OrMoreNeighbours_Dies()
        {
            // '#' == Alive
            // '-' == Dead
            var board = new GameOfLifeBoard(@"
##-
###
---".Trim());

            var result = @"
#-#
#-#
-#-".Trim();
            board.NextGeneration();

            Assert.That(board.ToString(), Is.EqualTo(result));
        }

        [Test]
        public void NextGeneration_AliveCellWith2Or3Neighbours_Lives()
        {
            // '#' == Alive
            // '-' == Dead
            var board = new GameOfLifeBoard(@"
--#
##-
---".Trim());

            var result = @"
-#-
-#-
---".Trim();
            board.NextGeneration();

            Assert.That(board.ToString(), Is.EqualTo(result));
        }

        [Test]
        public void NextGeneration_DeadCellWith3AliveNeighbours_Lives()
        {
            // '#' == Alive
            // '-' == Dead
            var board = new GameOfLifeBoard(@"
---
###
---".Trim());

            var result = @"
-#-
-#-
-#-".Trim();
            board.NextGeneration();

            Assert.That(board.ToString(), Is.EqualTo(result));
        } 
    }
}
