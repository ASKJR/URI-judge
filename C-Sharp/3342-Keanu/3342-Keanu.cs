using System;

class URI
{
    /*  
     *  Problem: Keanu
     *  beecrowd | 3342
     *  Solution developed by: Alberto Kato
     */
    static void Main(string[] args)
    {
        int whiteSquares = 0 , blackSquares = 0;
        int boardDimension = int.Parse(Console.ReadLine().Trim());
        int boardSize = (boardDimension * boardDimension);
        whiteSquares += (boardSize % 2) + (boardSize / 2);
        blackSquares += (boardSize / 2);
        Console.WriteLine("{0} casas brancas e {1} casas pretas", whiteSquares, blackSquares);
    }
}