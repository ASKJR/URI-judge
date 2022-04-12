using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Ordenando a Lista de Crianças do Papai Noel
     *  beecrowd | 2479
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int good = 0, bad = 0;
        string[] line;
        List<string> kids = new List<string>();

        for (int i = 0; i < n; i++)
        {
            line = Console.ReadLine().Split(' ');
            if (line[0] == "+") ++good;
            else ++bad;
            kids.Add(line[1]);
        }

        foreach(string kid in kids.OrderBy(name => name).ToArray())
        {
            Console.WriteLine(kid);
        }

        Console.WriteLine($"Se comportaram: {good} | Nao se comportaram: {bad}");
    }
}