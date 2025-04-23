using Chess.Models;
using Chess.Models.Pieces;
using Chess.Utils;

var inputString = string.Empty;
Console.WriteLine("This App will give the possible moves that a piece can take in a chess board. \nYou can give the piece and its current position to get the details.");
do
{
    try
    {
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.Write("Enter Position(Ex: Pawn, H2) or Enter Exit: ");
        inputString = Console.ReadLine();
        if (inputString == null) continue;
        if (inputString.ToLower() == "exit") break; //Checking as case insensitive format

        var input = inputString.Split(',');
        if (input.Length != 2)
        {
            Console.WriteLine("Input is not in the format, Give as comma separated.\n");
            continue;
        }
        GetMoves(input);
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }

}
while (true);

void GetMoves(string[] input)
{

    IChessBoard board = new BasicChessBoard();
    try
    {
        Piece piece = GetPiece(input);
        if (board.IsInsideBoard(piece.curRow, piece.curCol))
            piece.GetPossibleMoves(board).print();
        else
            Console.WriteLine("Piece Is Placed Outside The Board.\n");
    }
    catch(KeyNotFoundException e )
    {
        throw e;
    }
}
/// <summary>
/// Performs operation that might fail.
/// </summary>
/// <exception cref="KeyNotFoundException">Thrown when the piece not found.</exception>
Piece GetPiece(string[] input)
{

    var ChessPiece = input[0].Trim().ToLower();

    if (ChessPiece == "king")
    {
       return new King(input[1].Trim().ToUpper());
    }
    else if (ChessPiece == "pawn")
    {
        return new Pawn(input[1].Trim().ToUpper());
    }
    else if (ChessPiece == "queen")
    {
        return new Queen(input[1].Trim().ToUpper());
    }
    else
    {
        throw new KeyNotFoundException("Piece Not Found. Only King, Pawn and Queen are available.\n");
    }
}
