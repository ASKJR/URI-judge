using System;
using System.Text;

class URI
{
    /*  
     *  Problem: Então é Natal!
     *  beecrowd | 2926
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int repeatLetterNTimes = int.Parse(Console.ReadLine());
        Console.WriteLine(new StringBuilder("Entao eh Natal!")
            .Replace("a", new String('a', repeatLetterNTimes))
            .ToString());
    }
}