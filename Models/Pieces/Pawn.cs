using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Pieces
{
    internal class Pawn : Piece
    {
        public Pawn(string position) : base(position, PieceType.Pawn)
        {
        }

        public override List<string> GetPossibleMoves(IChessBoard board)
        {
            var moves = new List<string>();
            // As stated in the requirement, we assume pawn moves only one step forward.
            int row = Position[1] - '0';  
            int col = (Position[0] - 'A') + 1;       

            if (board.IsInsideBoard(row + 1, col))
                moves.Add(board.ToPosition(row + 1, col));  

            return moves;
        }
    }
}
