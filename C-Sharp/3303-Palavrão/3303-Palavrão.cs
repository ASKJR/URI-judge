using System;

class URI
{
    /*  
     *  Problem: Palavrão
     *  beecrowd | 3303
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {

        string line;
        while ((line = Console.ReadLine()) != null)
        {
            Console.WriteLine((line.Length >= 10 ? "palavrao" : "palavrinha"));
        }
    } 
}
