using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Letras
     *  beecrowd | 2457
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string letter = Console.ReadLine();
        string[] phrase = Console.ReadLine().Split(' ');
        float letterCount = phrase.Where(word => word.Contains(letter)).Count();
        Console.WriteLine(String.Format("{0:0.0}", (letterCount/phrase.Length)*100 ));
    }
}