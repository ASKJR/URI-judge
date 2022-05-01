using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: A Árvore de Natal
     *  beecrowd | 3040 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] input;

        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            if (input[0] >= 200 && input[0] <= 300 && input[1] >= 50 && input[2] >= 150)
                Console.WriteLine("Sim");
            else
                Console.WriteLine("Nao");
        }
    }

}