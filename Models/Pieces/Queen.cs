using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Pieces
{
    internal class Queen : Piece
    {

        public Queen(string position) : base(position, PieceType.Queen)
        {
        }

        public override List<string> GetPossibleMoves(IChessBoard board)
        {
            var moves = new List<string>();

            foreach (var (rowOffset, colOffset) in board.GetAllDirections())
            {
                int toRow = curRow + rowOffset;
                int toCol = curCol + colOffset;

                while (board.IsInsideBoard(toRow, toCol))
                {
                    moves.Add(board.ToPosition(toRow, toCol));
                    toRow += rowOffset;
                    toCol += colOffset;
                }

            }
            return moves;
        }

    }
}
