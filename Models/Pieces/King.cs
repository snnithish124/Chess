using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Pieces
{
    internal class King : Piece
    {
        public King(string position) : base(position, PieceType.King)
        {

        }

        public override List<string> GetPossibleMoves(IChessBoard board)
        {
            var moves = new List<string>();
            

            if (board.IsInsideBoard(curCol, curRow))
            {
                var directions = board.GetAllDirections();
                for (int i = 0; i < directions.Length; i++)
                {
                    int toRow = curRow + directions[i].row;
                    int toCol = curCol + directions[i].col;
                    if (board.IsInsideBoard(toRow, toCol))
                        moves.Add(board.ToPosition(toRow, toCol));
                }
            }
            return moves;
        }
    }
}
