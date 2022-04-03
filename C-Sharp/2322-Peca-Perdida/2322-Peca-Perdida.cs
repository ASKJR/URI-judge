using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Peça Perdida
     *  beecrowd | 2322
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        IEnumerable<int> allPieces = Enumerable.Range(1, N);
        IEnumerable<int> myPieces = Console.ReadLine().Split(' ').Select(piece => int.Parse(piece));
        Console.WriteLine(allPieces.Except(myPieces).First());
    }
}