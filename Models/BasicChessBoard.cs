using Chess.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    internal class BasicChessBoard : IChessBoard
    {
        private int row { get; set; }
        private int col { get; set; }
        private (int row, int col)[] directions = new (int, int)[]
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
        public BasicChessBoard() 
        {
            row = 8;
            col = 8;
        }
      
        public int GetRow()
        {
            return row;
        }

        public int GetCol()
        {
            return col;
        }
        public bool IsInsideBoard(int rowPos, int colPos)
        {
            
            return rowPos > 0 && rowPos <= row && colPos > 0 && colPos <= col;
            
        }
        public string ToPosition(int rowPos, int colPos)
        {
            return $"{(char)(('A' + colPos) - 1)}{ rowPos}";
        }
        public (int row, int col)[] GetAllDirections()
        {
            return directions;
        }
    }
}
