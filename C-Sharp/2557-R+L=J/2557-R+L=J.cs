using System;

class URI
{
    /*  
     *  Problem: R+L=J
     *  beecrowd | 2557 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line, R, L, J;
        string[] input;


        while ((line = Console.ReadLine()) != null)
        {
            input = line.Split('+'); //input[0] R
            R = input[0];
            input = input[1].Split('=');
            L = input[0];
            J = input[1];


            if (J == "J")
            {
                Console.WriteLine(int.Parse(R) + int.Parse(L));
            }
            else if (R == "R")
            {
                Console.WriteLine(int.Parse(J) - int.Parse(L));
            }
            else
            {
                Console.WriteLine(int.Parse(J) - int.Parse(R));
            }
        }
    }

}
