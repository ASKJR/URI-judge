using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Receita de Bolo
     *  beecrowd | 2423
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        input[0] = input[0]/2;
        input[1] = input[1]/3;
        input[2] = input[2]/5;
        Console.WriteLine(input.Min());
    }
}