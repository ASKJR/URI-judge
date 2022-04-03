using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Mergulho
     *  beecrowd | 1471
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;
        int N;
        while((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split(' ');
            N = int.Parse(input[0]);

            IEnumerable<int> survivors = Console.ReadLine().Split(' ').Select(survivor => int.Parse(survivor));
            IEnumerable<int> nSequence = Enumerable.Range(1, N);
            IEnumerable<int> deads = nSequence.Except(survivors).OrderBy(num => num);
            
            if (!deads.Any())
            {
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine(string.Join(" ", deads.ToArray()) + " ");
            }
        }
    }
}