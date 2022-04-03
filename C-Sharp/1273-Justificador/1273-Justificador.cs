using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Justificador
     *  beecrowd | 1273
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string N;
        string word;
        int space = 0;
        while ((N = Console.ReadLine()) != "0")
        {
            if (space > 0) Console.WriteLine();
            int casesNum = int.Parse(N);
            int max = 0;
            List<string> words = new List<string>();
            for (int i = 0; i < casesNum; i++)
            {
                word = Console.ReadLine();
                if (word.Length > max)
                {
                    max = word.Length;
                }
                words.Add(word);
            }
            foreach (var w in words)
            {
                Console.WriteLine(w.PadLeft(max));
            }
            space++;
        }
    }
}