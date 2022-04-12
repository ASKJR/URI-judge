using System;

class URI
{
    /*  
     *  Problem: Aaah!
     *  beecrowd | 3224
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string jon = Console.ReadLine();
        string doc = Console.ReadLine();
        if (jon.Length >= doc.Length) Console.WriteLine("go");
        else Console.WriteLine("no");
    }
}