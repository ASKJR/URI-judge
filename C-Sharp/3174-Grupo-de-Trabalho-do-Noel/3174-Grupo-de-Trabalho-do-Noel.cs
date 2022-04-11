using System;

class URI
{
    /*  
     *  Problem: Grupo de Trabalho do Noel
     *  beecrowd | 3174
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int B = 0, A = 0, M = 0, D = 0, hours, toys;
        string[] line; 
        string type;
        for (int i = 0; i < N; i++)
        {
            line = Console.ReadLine().Split(' ');
            type = line[1];
            hours = int.Parse(line[2]);
            
            if (type == "bonecos")
            {
                B += hours;
            } 
            else if (type == "arquitetos")
            {
                A += hours;
            }
            else if (type == "musicos")
            {
                M += hours;
            }
            else
            {
                D += hours;
            }
        }
        
        toys = (B/8) + (A/4) + (M/6) + (D/12);
        
        Console.WriteLine(toys);
    }
}