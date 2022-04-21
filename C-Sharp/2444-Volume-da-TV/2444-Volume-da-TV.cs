using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Volume da TV
     *  beecrowd | 2444
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int[] input1 = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        int[] input2 = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        int volume = input1[0];
        
        for (int i = 0; i < input2.Length; i++)
        {
            volume += input2[i];
            if (volume > 100) volume = 100;
            if (volume < 0) volume = 0;
        }

        Console.WriteLine(volume);
    }
}