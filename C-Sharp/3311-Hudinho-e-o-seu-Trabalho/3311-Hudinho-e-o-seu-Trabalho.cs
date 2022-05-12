using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Hudinho e o seu Trabalho
     *  beecrowd | 3311 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string name, firstLetter;
        SortedDictionary<string, List<string>> names = new SortedDictionary<string, List<string>>();

        for (int i = 0; i < N; i++)
        {
            name = Console.ReadLine();
            firstLetter = name.Substring(0, 1);
            if (names.ContainsKey(firstLetter))
            {
                names[firstLetter].Add(name);
            }
            else
            {
                names.Add(firstLetter, new List<string>());
                names[firstLetter].Add(name);
            }
        }
        foreach (List<string> entries in names.Values)
        {
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
