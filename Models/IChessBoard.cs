﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public interface IChessBoard
    {

        int GetRow();
        int GetCol();
        bool IsInsideBoard(int rowPos, int colPos);
        string ToPosition(int r, int c);
        (int row, int col)[] GetAllDirections();
    }
}
