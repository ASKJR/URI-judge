using System;
using System.Numerics;

class URI
{
    /*  
     *  Problem: Ano Bissexto ou Ano não Bissexto
     *  beecrowd | 1279 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string line;
        BigInteger year;
        int count = 0;
        while ((line = Console.ReadLine()) != null)
        {
            year = BigInteger.Parse(line);
            if (count > 0) Console.WriteLine();
            if (!IsLeapYear(year) && !IsHuluculu(year) && !IsBulukulu(year)) Console.WriteLine("This is an ordinary year.");
            if (IsLeapYear(year)) Console.WriteLine("This is leap year.");
            if (IsHuluculu(year)) Console.WriteLine("This is huluculu festival year.");
            if (IsBulukulu(year)) Console.WriteLine("This is bulukulu festival year.");
            ++count;

        }
    }

    public static bool IsLeapYear(BigInteger year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

    public static bool IsHuluculu(BigInteger year)
    {
        return year % 15 == 0;
    }

    public static bool IsBulukulu(BigInteger year)
    {
        return IsLeapYear(year) && year % 55 == 0;
    }
}