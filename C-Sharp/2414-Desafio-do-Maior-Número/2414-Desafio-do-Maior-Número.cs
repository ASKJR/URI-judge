using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Desafio do Maior Número
     *  beecrowd | 2414 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().Split(' ').Select(n => int.Parse(n)).Max()); 
    }
}