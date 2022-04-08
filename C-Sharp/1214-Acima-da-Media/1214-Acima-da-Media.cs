using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Acima da Média
     *  beecrowd | 1214
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int C = int.Parse(Console.ReadLine());
        IEnumerable<decimal> input;
        decimal avg, aboveAvgPercent, first;
        for (int i = 0; i < C; i++)
        {
            input = Console.ReadLine().Split(' ').Select(n => decimal.Parse(n));
            first = input.First();
            input = input.Skip(1);
            avg = input.Average();
            aboveAvgPercent = ((input.Where(n => n > avg).Count()) / first)*100;
            Console.WriteLine(String.Format("{0:0.000}%", Math.Round(aboveAvgPercent,3)));
        }
    }
}