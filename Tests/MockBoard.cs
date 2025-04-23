using Chess.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Tests
{
    public class MockBoard : IChessBoard
    {
        public bool IsInsideBoard(int row, int col) => row > 0 && row <= 8 && col > 0 && col <= 8;

        public string ToPosition(int row, int col)
        {
            return $"{(char)(('A' + col) - 1)}{row}";

        }

        public (int row,int col)[] GetAllDirections() 
        {
                return new (int, int)[]
                {
                (-1,  0), // up
                ( 1,  0), // down
                ( 0, -1), // left
                ( 0,  1), // right
                (-1, -1), // upLeft
                (-1,  1), // upRight
                ( 1, -1), // downLeft
                ( 1,  1)  // downRight
                };
        }

        public int GetRow()
        {
            return 8;
        }

        public int GetCol()
        {
            return 8;
        }

      
    }
}
