using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: A Última Criança Boa
     *  beecrowd | 2023 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;
        SortedDictionary<string,string> dic = new SortedDictionary<string,string>();
        
        while ((line = Console.ReadLine()) != null)
        {
            if (!dic.ContainsKey(line.ToLower()))
            {
                dic.Add(line.ToLower(), line);
            }
            
        }

        Console.WriteLine(dic.Last().Value);
    }
}
