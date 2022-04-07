using System;

class URI
{
    /*  
     *  Problem: Escada do DINF
     *  beecrowd | 2518
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;
        string[] input;
        int N, H, C, L;
        double hip, stairsArea;
        while((line = Console.ReadLine()) != null)
        {
            input = Console.ReadLine().Split(' ');
            N = int.Parse(line);
            H = int.Parse(input[0]);
            C = int.Parse(input[1]);
            L = int.Parse(input[2]);
            hip = Math.Sqrt((H*H)+(C*C));
            stairsArea = ((hip * N) * L) / 10000;
            Console.WriteLine(String.Format("{0:0.0000}", stairsArea));
        }
    }
}