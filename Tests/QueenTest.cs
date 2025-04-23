using Chess.Models.Pieces;
using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chess.Tests
{
    public class QueenTests
    {
     

        [Fact]
        public void QueenAtCenterOfBoard()
        {
            var board = new MockBoard();
            var queen = new Queen("D4");

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("D5", moves);
            Assert.Contains("D3", moves);
            Assert.Contains("C4", moves);
            Assert.Contains("E4", moves);
            Assert.Contains("E5", moves);
            Assert.Contains("C5", moves);
            Assert.Contains("E3", moves);
            Assert.Contains("C3", moves);
            Assert.DoesNotContain("D4", moves);
        }

        [Fact]
        public void QueenLeftCorner()
        {
            var board = new MockBoard();
            var queen = new Queen("A8"); 

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("A7", moves);  
            Assert.Contains("B8", moves);  
            Assert.Contains("B7", moves);  
            Assert.DoesNotContain("A8", moves);
            Assert.DoesNotContain("A9", moves);
            Assert.DoesNotContain("Z8", moves); 
        }

        [Fact]
        public void QueenBottomRight()
        {
            var board = new MockBoard();
            var queen = new Queen("H1"); 

            var moves = queen.GetPossibleMoves(board);

            Assert.Contains("G1", moves);  
            Assert.Contains("H2", moves);  
            Assert.Contains("G2", moves);  
            Assert.DoesNotContain("H1", moves);
        }

        [Fact]
        public void QueenExcludeOwnPosition()
        {
            var board = new MockBoard();
            var queen = new Queen("D4");

            var moves = queen.GetPossibleMoves(board);

            Assert.DoesNotContain("D4", moves);
        }

    }
}
