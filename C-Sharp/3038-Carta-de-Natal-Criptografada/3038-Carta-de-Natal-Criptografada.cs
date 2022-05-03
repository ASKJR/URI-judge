using System;

class URI
{
    /*  
     *  Problem: Carta de Natal Criptografada
     *  beecrowd | 3038 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;

        while ((line = Console.ReadLine()) != null)
        {
            line = line
             .Replace("@", "a")
             .Replace("&", "e")
             .Replace("!", "i")
             .Replace("*", "o")
             .Replace("#", "u");

            Console.WriteLine(line);
        }
    }

}
