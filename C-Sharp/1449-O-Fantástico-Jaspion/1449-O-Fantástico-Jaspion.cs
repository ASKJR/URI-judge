using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: O Fantástico Jaspion
     *  beecrowd | 1449 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M, K;
        string[] input, phrase;
        string key, value;

        for (int i = 0; i < N; i++)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            input = Console.ReadLine().Split(' ');
            M = int.Parse(input[0]);
            K = int.Parse(input[1]);

            for(int j = 0; j < M; j++)
            {
                key = Console.ReadLine();
                value = Console.ReadLine();
                if (!words.ContainsKey(key))
                {
                    words.Add(key, value);
                }
            }

            for(int z = 0; z < K; z++)
            {
                string output = "";

                phrase = Console.ReadLine().Split();
                
                foreach (string word in phrase)
                {
                    if (!words.ContainsKey(word))
                    {
                        output += $"{word} ";
                    } 
                    else
                    {
                        output += $"{words[word]} ";
                    }
                }

                Console.WriteLine(output.Trim());
            }

            Console.WriteLine();
        }
    }
}