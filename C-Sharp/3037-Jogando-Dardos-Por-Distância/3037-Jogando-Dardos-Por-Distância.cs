using System;

class URI
{
    /*  
     *  Problem: Jogando Dardos Por Distância
     *  beecrowd | 3037 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int J, M;
        string[] input;

        for (int i = 0; i < N; i++)
        {
            J = 0;
            M = J;

            for (int j = 0; j < 3; j++)
            {
                input = Console.ReadLine().Split(' ');
                J += int.Parse(input[0]) * int.Parse(input[1]);
            }

            for (int k = 0; k < 3; k++)
            {
                input = Console.ReadLine().Split(' ');
                M += int.Parse(input[0]) * int.Parse(input[1]);
            }

            if (J > M)
            {
                Console.WriteLine("JOAO");
            } 
            else
            {
                Console.WriteLine("MARIA");
            }
        }
    }
}
