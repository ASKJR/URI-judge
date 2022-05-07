using System;

class URI
{
    /*  
     *  Problem: Números Má Sorte Recarregados
     *  beecrowd | 3300 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string N = Console.ReadLine();
        if (N.Contains("13"))
        {
            Console.WriteLine($"{N} es de Mala Suerte");
        } 
        else
        {
            Console.WriteLine($"{N} NO es de Mala Suerte");
        }

    }
}
