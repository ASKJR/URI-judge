using System;

class URI
{
    /*  
     *  Problem: Contando Caracters
     *  beecrowd | 2108
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string[] words;
        string longestWord = "";
        
        for(; ; )
        {
            words = Console.ReadLine().Split(' ');
            if (words[0] == "0") 
            {
                Console.WriteLine();
                break;
            }
            
            
            string output = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= longestWord.Length)
                {
                    longestWord = words[i];
                }
                if (i==(words.Length-1))
                {
                    output += $"{words[i].Length}";
                } 
                else
                {
                    output += $"{words[i].Length}-";
                }
            }

            Console.WriteLine(output);
        }

        Console.WriteLine($"The biggest word: {longestWord}");
    }
}