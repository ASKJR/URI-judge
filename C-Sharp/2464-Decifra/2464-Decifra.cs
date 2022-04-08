using System;

class URI
{
    /*  
     *  Problem: Decifra
     *  beecrowd | 2464
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string rule = Console.ReadLine();
        string toDecode = Console.ReadLine();
        string decoded = "";
        
        foreach(char c in toDecode)
        {
            decoded+= rule[alphabet.IndexOf(c)];
        }

        Console.WriteLine(decoded);
    }
}