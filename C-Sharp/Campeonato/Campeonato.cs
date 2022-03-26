using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Campeonato
     *  beecrowd | 2417
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
       
        int[] input = Console.ReadLine().Split(' ').Select(age => int.Parse(age)).ToArray();
        int cormengoPoints = (input[0]*3) + input[1];
        int flaminthiansPoint = (input[3] * 3) + input[4];
        if (cormengoPoints > flaminthiansPoint)
        {
            Console.WriteLine("C");
        } 
        else if (flaminthiansPoint > cormengoPoints)
        {
            Console.WriteLine("F");
        } 
        else
        {
            if (input[2] > input[5]) 
            { 
                Console.WriteLine("C"); 
            }
            else if(input[5] > input[2])
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("=");
            }

        }

    }
}