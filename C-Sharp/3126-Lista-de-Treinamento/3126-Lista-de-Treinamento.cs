using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Lista de Treinamento
     *  beecrowd | 3126 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {

        string N = Console.ReadLine();
        Console.WriteLine(Console.ReadLine().Split(' ').Select(n => int.Parse(n)).Sum()); 
    }
}
