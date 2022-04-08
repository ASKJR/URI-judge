using System;

class URI
{
    /*  
     *  Problem: O Matemático
     *  beecrowd | 2691
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] line;
        int X, Y;
        for (int i = 0; i < N; i++)
        {
            line = Console.ReadLine().Split('x');
            X = int.Parse(line[0]);
            Y = int.Parse(line[1]);

            for (int j = 5; j <= 10; j++)
            {
                if (X==Y)
                {
                    Console.WriteLine($"{X} x {j} = {X*j}");
                } 
                else
                {
                    Console.WriteLine($"{X} x {j} = {X * j} && {Y} x {j} = {Y * j}");
                }
            }
        }
    }
}