using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Abreviações
     *  beecrowd | 1519
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {

        string line;
        while ((line = Console.ReadLine()) != ".")
        {
            PrintAbbreviates(Abbreviate(line));
        }
    }

    static SortedDictionary<string, string> Abbreviate(string phrase)
    {
        SortedDictionary<string, string> abbreviateWords = new SortedDictionary<string, string>();
        Dictionary<string, int> repeatedWords = new Dictionary<string, int>();
        string[] words = phrase.Trim().Split(' ');
        string key;
        foreach (string word in words)
        {
            key = word.Substring(0, 1);
            if (!repeatedWords.ContainsKey(word))
            {
                repeatedWords.Add(word, (word.Length) - 2);
            }
            else
            {
                repeatedWords[word] += (word.Length) - 2;
            }

            if (abbreviateWords.ContainsKey(key))
            {
                var repeatedWordKey = repeatedWords
                    .Where(i => i.Key.StartsWith(key) && (i.Value > (word.Length - 2)))
                    .OrderByDescending(i => i.Value)
                    .Select(i => i.Key)
                    .FirstOrDefault();
                if ((abbreviateWords[key].Length-2) < (word.Length-2) && repeatedWordKey == null)
                {
                    abbreviateWords[key] = word;
                }
                if (repeatedWordKey != null)
                {
                    if ((word.Length - 2) < repeatedWords[repeatedWordKey])
                    {
                        abbreviateWords[key] = repeatedWordKey;
                    }
                }
            }
            else
            {
                if (word.Length > 2)
                {
                    abbreviateWords.Add(key, word);
                }
            }
        }
        string toPrint = "";
        foreach (string word in words)
        {
            key = word.Substring(0, 1);
            if (abbreviateWords.ContainsKey(key))
            {
                if (abbreviateWords[key] != word)
                {
                    toPrint += word + " ";
                }
                else
                {
                    toPrint += key + ". ";
                }
            }
            else
            {
                toPrint += word + " ";
            }
        }
        Console.WriteLine(toPrint.Trim());

        return abbreviateWords;
    }

    static void PrintAbbreviates(SortedDictionary<string, string> abbreviates)
    {
        Console.WriteLine(abbreviates.Count);
        foreach (string key in abbreviates.Keys)
        {
            Console.WriteLine($"{key}. = {abbreviates[key]}");
        }
    }
}