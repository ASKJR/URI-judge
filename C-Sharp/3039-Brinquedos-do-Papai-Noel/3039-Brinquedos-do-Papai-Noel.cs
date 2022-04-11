using System;

class URI
{
    /*  
     *  Problem: Brinquedos do Papai Noel
     *  beecrowd | 3039
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int dolls = 0, cars = 0;
        string g;
        
        for (int i = 0; i < N; i++)
        {
            g = Console.ReadLine().Split(' ')[1];
            if (g == "M") ++cars;
            else ++dolls;
        }

        Console.WriteLine($"{cars} carrinhos");
        Console.WriteLine($"{dolls} bonecas");
    }
}