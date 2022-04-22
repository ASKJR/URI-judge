using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Soma Natural
     *  beecrowd | 1805 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        
        long[] interval = Console.ReadLine().Split(' ').Select(n => long.Parse(n)).ToArray();
        Console.WriteLine((((interval[1]-interval[0])+1)*(interval[0] + interval[1]))/2);
    }
}