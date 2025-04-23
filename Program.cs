using Chess.Models;
using Chess.Models.Pieces;
using Chess.Utils;

var inputString = string.Empty;

do
{
    try
    {
        Console.Write("Enter Position(Ex: Pawn, H2) or Enter Exit: ");
        inputString = Console.ReadLine();
        if (inputString.ToLower() == "exit") break; //Checking as case insensitive format

        var input = inputString.Split(',');
        if (input.Length != 2)
        {
            Console.WriteLine("Input is not in the format, Give as comma separated");
            continue;
        }

        IChessBoard board = new BasicChessBoard();
        var ChessPiece = input[0].Trim().ToLower();

        Piece piece = null;
        if (ChessPiece == "king")
        {
            piece = new King(input[1].Trim().ToUpper());
        }
        else if (ChessPiece == "pawn")
        {
            piece = new Pawn(input[1].Trim().ToUpper());
        }
        else if (ChessPiece == "queen")
        {
            piece = new Queen(input[1].Trim().ToUpper());
        }
        else
        {
            Console.WriteLine("Given Piece Not Found");
            continue;
        }

        if (board.IsInsideBoard(piece.curRow, piece.curCol))
            piece.GetPossibleMoves(board).print();
        else
            Console.WriteLine("Piece Is Placed Outside The Board");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }

}
while (true);

