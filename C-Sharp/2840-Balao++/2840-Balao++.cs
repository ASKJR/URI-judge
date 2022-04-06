using System;

class URI
{
    /*  
     *  Problem: Balão++
     *  beecrowd | 2840
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        double PI = 3.1415;
        string[] input = Console.ReadLine().Split(' ');
        int radius = int.Parse(input[0]);
        int availableHe = int.Parse(input[1]);  
        double sphereV = (4 * PI * (radius * radius * radius)) / 3;
        Console.WriteLine((int)(availableHe/sphereV));
    }
}