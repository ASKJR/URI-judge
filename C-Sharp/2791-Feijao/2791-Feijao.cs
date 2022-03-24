using System;

class URI
{
    /*  
     *  Problem: Feijão
     *  beecrowd | 2791
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split(' ');
        Console.WriteLine(Array.FindIndex(input, item => item == "1") + 1);
    }
}