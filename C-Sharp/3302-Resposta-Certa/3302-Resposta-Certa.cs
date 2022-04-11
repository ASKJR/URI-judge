using System;

class URI
{
    /*  
     *  Problem: Resposta Certa
     *  beecrowd | 3302
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line, answer;
        int N;
        
        while ((line = Console.ReadLine()) != null)
        {
            N = int.Parse(line);
            for (int i = 1; i <= N; i++)
            {
                answer = Console.ReadLine();
                Console.WriteLine($"resposta {i}: {answer}");
            }
        }
    }
}