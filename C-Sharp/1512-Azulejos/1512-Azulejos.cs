using System;

class URI
{
    /*  
     *  Problem: Azulejos
     *  beecrowd | 1512 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string[] input;
        int N, A, B, lastDivisibleA, firstDivisibleA, lastDivisibleB, firstDivisibleB, sumDivisible;
        
        for (; ;)
        {
            input = Console.ReadLine().Split(' ');
            N = int.Parse(input[0]);
            A = int.Parse(input[1]);
            B = int.Parse(input[2]);
            
            if (N == 0 && A == 0 && B == 0) break;

            lastDivisibleA = GetLastMultiple(N, A, B);
            lastDivisibleB = GetLastMultiple(N, B, B);
            firstDivisibleA = A;
            firstDivisibleB = B;
            sumDivisible = GetHowManyDivisible(firstDivisibleA, lastDivisibleA, A) + GetHowManyDivisible(firstDivisibleB, lastDivisibleB, B);
            
            Console.WriteLine(sumDivisible);
        }
    }
    static int GetHowManyDivisible(int firstDivisible, int lastDivisible, int divisibleBy)
    {
        return ((lastDivisible - firstDivisible) / divisibleBy) + 1;
    }

    static int GetLastMultiple(int N, int A, int B)
    {
        for (int i = (N-1); i >= 0; i--)
        {
            if (i % A == 0 || i % B == 0) return i;
        }
        return -1;
    }

}