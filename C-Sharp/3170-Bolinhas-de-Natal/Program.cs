using System;

class URI
{
    /*  
     *  Problem: Bolinhas de Natal
     *  beecrowd | 3170 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int B, G;
        int output;
        B = int.Parse(Console.ReadLine());
        G = int.Parse(Console.ReadLine());
        output = (G / 2) - B;
        if (output <= 0) Console.WriteLine("Amelia tem todas bolinhas!");
        else Console.WriteLine($"Faltam {output} bolinha(s)");
    }
   
}