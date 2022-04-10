using System;

class URI
{
    /*  
     *  Problem: Números Má Sorte Pequenos
     *  beecrowd | 3299
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (input.Contains("13"))
        {
            Console.WriteLine($"{input} es de Mala Suerte");
        } 
        else
        {
            Console.WriteLine($"{input} NO es de Mala Suerte");
        }
    }
}
