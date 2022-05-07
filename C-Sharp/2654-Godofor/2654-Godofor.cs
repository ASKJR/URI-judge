using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Godofor
     *  beecrowd | 2654 
     *  Solution developed by: Alberto Kato
     */
    public class Entity
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int KilledGodsCount { get; set; }
        public int DeathsCount { get; set; }
    }
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] line;
        List<Entity> entities = new List<Entity>();
        
        for (int i = 0; i < N; i++)
        {
            line = Console.ReadLine().Split(' ');
            entities.Add(new Entity { 
                Name = line[0], 
                Power = int.Parse(line[1]), 
                KilledGodsCount = int.Parse(line[2]), 
                DeathsCount = int.Parse(line[3])
            });
        }

        Entity winner = entities
            .OrderByDescending(e => e.Power)
            .ThenByDescending(e => e.KilledGodsCount)
            .ThenBy(e => e.DeathsCount)
            .ThenBy(e => e.Name, StringComparer.Ordinal)
            .ThenBy(e => e.Name.Length).ToArray()[0];

        Console.WriteLine(winner.Name);
    }
}
