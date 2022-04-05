using System;

class URI
{
    /*  
     *  Problem: A Greve para ou Continua?
     *  beecrowd | 2982
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int G = 0, V = 0;
        string[] input; 
        string type;
        while (N > 0)
        {
            input = Console.ReadLine().Split(' ');
            type = input[0];
            if (type == "G")
            {
                G += int.Parse(input[1]);
            }
            else
            {
                V += int.Parse(input[1]);
            }
            N--;
        }
        if (V >= G)
        {
            Console.WriteLine("A greve vai parar.");
        }
        else
        {
            Console.WriteLine("NAO VAI TER CORTE, VAI TER LUTA!");
        }
    }
}