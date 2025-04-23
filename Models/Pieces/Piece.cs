using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models.Pieces
{
    public abstract class Piece
    {
        public string Position { get; set; }
        public PieceType Type { get; set; }
        public readonly int curRow;
        public readonly int curCol;
        public Piece(string position, PieceType type)
        {
            Position = position;
            Type = type;
            curRow = Position[1] - '0';
            curCol = (Position[0] - 'A') + 1;
        }

        public abstract List<string> GetPossibleMoves(IChessBoard board);
    }
}
