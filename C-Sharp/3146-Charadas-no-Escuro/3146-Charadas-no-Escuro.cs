using System;

class URI
{
    /*  
     *  Problem: Charadas no Escuro
     *  beecrowd | 3146
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("{0:0.00}", Math.Round(r * 6.28, 2)));
    }
}