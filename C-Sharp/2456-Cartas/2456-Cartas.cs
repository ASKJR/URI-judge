using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Cartas
     *  beecrowd | 2456 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        int[] ascending = input.OrderBy(l => l).ToArray();
        int[] descending = input.OrderByDescending(l => l).ToArray();
        

        if (input.SequenceEqual(ascending))
        {
            Console.WriteLine("C");
        } 
        else if (input.SequenceEqual(descending))
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("N");
        }

    }
}
