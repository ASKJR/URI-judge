using System;
class URI
{
   /*  
    *  Problem: Saída 10
    *  beecrowd | 2756  
    *  Solution developed by: Alberto Kato
    */
    static void Main(string[] args)
    {
        //This program prints a diamond shape using letters A to E.
        var stringWith7Spaces = new string(' ', 7);
        var stringWith6Spaces = new string(' ', 6);
        var stringWith5Spaces = new string(' ', 5);
        var stringWith4Spaces = new string(' ', 4);
        var stringWith3Spaces = new string(' ', 3);
        //1
        Procedure1(stringWith7Spaces);
        //2
        Procedure2(stringWith6Spaces);
        //3
        Procedure3(stringWith5Spaces, stringWith3Spaces);
        //4
        Procedure4(stringWith5Spaces, stringWith4Spaces);
        //5
        Console.WriteLine($"{stringWith3Spaces}E{stringWith7Spaces}E");

        Procedure4(stringWith5Spaces, stringWith4Spaces);

        Procedure3(stringWith5Spaces, stringWith3Spaces);

        Procedure2(stringWith6Spaces);

        Procedure1(stringWith7Spaces);
    }

    private static void Procedure1(string stringWith7Spaces)
    {
        Console.WriteLine($"{stringWith7Spaces}A");
    }

    private static void Procedure2(string stringWith6Spaces)
    {
        Console.WriteLine($"{stringWith6Spaces}B B");
    }

    private static void Procedure3(string stringWith5Spaces, string stringWith3Spaces)
    {
        Console.WriteLine($"{stringWith5Spaces}C{stringWith3Spaces}C");
    }

    private static void Procedure4(string stringWith5Spaces, string stringWith4Spaces)
    {
        Console.WriteLine($"{stringWith4Spaces}D{stringWith5Spaces}D");
    }
}

