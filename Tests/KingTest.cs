using Chess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chess.Tests
{
    public class KingTest
    {
        [Fact]
        public void KingAtCenterOfBoard()
        {
            var board = new MockBoard();
            var queen = new King("D4");

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("C5", moves);
            Assert.Contains("C3", moves);
            Assert.Contains("C4", moves);
            Assert.Contains("E4", moves);
            Assert.Contains("E5", moves);
            Assert.Contains("E3", moves);
            Assert.DoesNotContain("F4", moves);
            Assert.True(moves.Count == 8);

        }

        [Fact]
        public void KingAtCorner()
        {
            var board = new MockBoard();
            var queen = new King("A1");

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("B1", moves);
            Assert.Contains("B2", moves);
            Assert.Contains("A2", moves);
            Assert.True( moves.Count == 3);

        }

        [Fact]
        public void KingAtTop()
        {
            var board = new MockBoard();
            var queen = new King("D8");

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("C7", moves);
            Assert.Contains("D7", moves);
            Assert.Contains("E7", moves);
            Assert.DoesNotContain("F7", moves);
            Assert.True(moves.Count == 5);

        }

        [Fact]
        public void KingExcludeOwnPosition()
        {
            var board = new MockBoard();
            var queen = new King("D4");

            var moves = queen.GetPossibleMoves(board);

            Assert.DoesNotContain("D4", moves);
        }
    }
}
