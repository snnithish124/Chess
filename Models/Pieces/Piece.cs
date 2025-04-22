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
        public Piece(string position, PieceType type)
        {
            Position = position;
            Type = type;
        }

        public abstract List<string> GetPossibleMoves(IChessBoard board);
    }
}
