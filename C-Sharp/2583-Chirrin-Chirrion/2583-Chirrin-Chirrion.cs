using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Chirrin Chirrion
     *  beecrowd | 2583 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M;
        string[] line;
       
        for (int i = 0; i < N; i++)
        {
            M = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();
            
            for (int j = 0; j < M; j++)
            {
                line = Console.ReadLine().Split(' ');
                
                if (line[1] == "chirrin" && !set.Contains(line[0]))
                {
                    set.Add(line[0]);
                }
                
                if (line[1] == "chirrion" && set.Contains(line[0]))
                {
                    set.Remove(line[0]);
                }
            }
            
            Console.WriteLine("TOTAL");

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}
