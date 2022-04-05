using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Garçom
     *  beecrowd | 2373
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int brokenCount = 0;
        int[] input;

        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            if(input[0] > input[1])
            {
                brokenCount+= input[1];
            }
        }

        Console.WriteLine(brokenCount);
    }
}