using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Primeiro Dicionário de Andy
     *  beecrowd | 1215
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {

        string phrase;
        SortedSet<string> wordsSet = new SortedSet<string>();

        while ((phrase = Console.ReadLine()) != null)
        {
            if (phrase != "")
            {
                var words = phrase.Split(' ');
                foreach (var word in words)
                {

                    string newString = "";
                    foreach (var letter in word)
                    {
                        if (!((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z')))
                        {
                            newString += "_";
                        } 
                        else
                        {
                            newString += letter;
                        }
                    }
                    var newStrings = newString.Split('_');
                    foreach (var item in newStrings)
                    {
                        wordsSet.Add(item.ToLower());
                    }
                    
                }
            }
        }
        foreach (var item in wordsSet)
        {
            if(item != "")
                Console.WriteLine(item);
        }

    }
}