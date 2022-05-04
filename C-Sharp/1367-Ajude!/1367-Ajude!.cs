using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Ajude!
     *  beecrowd | 1367 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N, correct, time;
        string[] input;
        List<string> correctLetter;
        List<string> incorrectLetter;

        while (true)
        {
            N = int.Parse(Console.ReadLine());
            
            if (N == 0) break;


            correct = 0;
            time = 0;
            correctLetter = new List<string>();
            incorrectLetter = new List<string>();

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split(' ');

                if (input[2] == "correct")
                {
                    if (!correctLetter.Contains(input[0]))
                    {
                        correctLetter.Add(input[0]);
                    }
                    correct++;
                    time+= int.Parse(input[1]);
                } 
                else
                {
                    incorrectLetter.Add(input[0]);
                }
            }

            foreach (string letter in incorrectLetter)
            {
                if(correctLetter.Contains(letter))
                {
                    time += 20;
                }
            }

            if (correct == 0) time = 0;

            Console.WriteLine($"{correct} {time}");
        }
        
    }
}
