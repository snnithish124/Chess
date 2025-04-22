﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    internal interface IChessBoard
    {
        void ResetBoard();
        void CleanBoard();
        int GetRow();
        int GetCol();
    }
}
