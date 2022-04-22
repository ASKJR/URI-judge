using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: A idade de Dona Mônica
     *  beecrowd | 3047
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = M - (A + B);
        int[] ages = new int[] { A, B, C };
        Console.WriteLine(ages.Max());
    }

}