using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Etiquetas de Noel
     *  beecrowd | 2482
     *  Solution developed by: Alberto Kato
     */


    static void Main(string[] args)
    {
        Dictionary<string, string> MerryChristmasDictionary = new Dictionary<string, string>();
        
        int n = int.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            string languageKey = Console.ReadLine().Trim();
            string languageValue = Console.ReadLine().Trim();

            MerryChristmasDictionary[languageKey] = languageValue;
        }

        int kidsN = int.Parse(Console.ReadLine().Trim());

        while (kidsN > 0)
        {
            kidsN--;
            string kidName = Console.ReadLine().Trim();
            string languageKey = Console.ReadLine().Trim();
            Console.WriteLine("{0}", kidName);
            Console.WriteLine("{0}\n", MerryChristmasDictionary[languageKey]);
        }
    }
}