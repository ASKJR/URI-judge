using System;

class URI
{
    /*  
     *  Problem: Correção de Texto
     *  beecrowd | 3088 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;
        string output;

        while ((line = Console.ReadLine()) != null)
        {
            output = line.Replace(" ,", ",");
            Console.WriteLine(output.Replace(" .", "."));
        }
    }

}