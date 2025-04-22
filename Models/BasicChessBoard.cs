using Chess.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    internal class BasicChessBoard : IChessBoard
    {
        public string[,] board { get; set; }
        private int row { get; set; }
        private int col { get; set; }
        public BasicChessBoard() 
        {
            row = 8;
            col = 8;
            board = new string[row,col];
            MarkCells();
        }
        public void CleanBoard()
        {
            board = new string[row,col];
        }

        public void ResetBoard()
        {
            MarkCells();
        }

        private void MarkCells()
        {
            int curRow = row - 1;
            while(curRow >= 0)
            {
                for(int i = 0;i < col; i++)
                {
                    var curChar = (char)('A' + i);
                    board[curRow, i] = $"{curChar}{curRow + 1}";
                }
                curRow--;
            }
            board.print();
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
            
            return rowPos >= 0 && rowPos < row && col >= 0 && colPos < col;
            
        }
        public string ToPosition(int rowPos, int colPos)
        {
            return $"{(char)('A' + colPos)}{row - rowPos}";
        }
    }
}
