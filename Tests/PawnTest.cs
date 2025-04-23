using Chess.Models.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chess.Tests
{
    public class PawnTest
    {
        [Fact]
        public void PawnAtOutsideBoard()
        {
            var board = new MockBoard();
            var queen = new Pawn("L4");

            var moves = queen.GetPossibleMoves(board);
            Assert.True(moves.Count == 0);

        }

        [Fact]
        public void PawnAtTop()
        {
            var board = new MockBoard();
            var queen = new Pawn("D8");

            var moves = queen.GetPossibleMoves(board);
            Assert.True(moves.Count == 0);

        }

        [Fact]
        public void PawnAtCenter()
        {
            var board = new MockBoard();
            var queen = new Pawn("D4");

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("D5", moves);
            Assert.DoesNotContain("D3", moves);
            Assert.DoesNotContain("D6", moves);
            Assert.True(moves.Count == 1);

        }

        [Fact]
        public void PawnExcludeOwnPosition()
        {
            var board = new MockBoard();
            var queen = new Pawn("D4");

            var moves = queen.GetPossibleMoves(board);

            Assert.DoesNotContain("D4", moves);
        }
    }
}
