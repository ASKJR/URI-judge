using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Língua do Computador
     *  beecrowd | 3315 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        List<int> count = new List<int>();
        int max;

        for (int i = 0; i < 4; i++)
        {
            count.Add(Console.ReadLine().Split(' ').Select(n => int.Parse(n)).Sum());
        }

        max = count.Max();

        Console.WriteLine($"{max} = {Convert.ToString(max,2)}");
    }
}
