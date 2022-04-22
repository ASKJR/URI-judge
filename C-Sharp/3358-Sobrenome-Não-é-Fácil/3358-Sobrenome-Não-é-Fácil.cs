using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Sobrenome Não é Fácil
     *  beecrowd | 3358 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string surname;

        for (int i = 0; i < N; i++)
        {
            surname = Console.ReadLine();
            if (!isHard(surname))
            {

                Console.WriteLine($"{surname} eh facil");
            } 
            else
            {
                Console.WriteLine($"{surname} nao eh facil");
            }
        }
    }

    public static bool isHard(string surname)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int countConsonant = 0;

        foreach (char letter in surname)
        {
            if(!vowels.Contains(letter))
            {
                ++countConsonant;
            } 
            else
            {
                countConsonant = 0;
            }

            if (countConsonant == 3) break;
        }

        return countConsonant == 3;
    }
}