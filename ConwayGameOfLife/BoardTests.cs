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
    }
}
