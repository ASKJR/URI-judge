using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Diga-me a Frequência
     *  beecrowd | 1251
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;
        int space = 0;
        
        while((line = Console.ReadLine())!= null)
        {
            if (space > 0) Console.WriteLine();
            SortedDictionary<int,int> dictionary = new SortedDictionary<int,int>();
            foreach (char c in line)
            {
                if(dictionary.ContainsKey(c))
                {
                    ++dictionary[c];
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }
            var items = dictionary
                .OrderBy(item => item.Value)
                .ThenByDescending(item => item.Key)
                .Select(item => "" + item.Key + " " + item.Value)
                .ToList();


            foreach (var item in items)
            {
                if (item != "")
                    Console.WriteLine(item);
            }
            space++;
            
        }
    }
}