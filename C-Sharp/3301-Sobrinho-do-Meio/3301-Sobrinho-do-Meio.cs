using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Sobrinho do Meio!
     *  beecrowd | 3301
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string[] names = new string[] { "huguinho", "zezinho", "luisinho" };
        int[] ages = Console.ReadLine().Split(' ').Select(age => int.Parse(age)).ToArray();
        var namesAndAges = names
            .Zip(ages, (name,age) => new { name, age })
            .OrderBy(nameAndAge => nameAndAge.age)
            .ToArray();

        Console.WriteLine(namesAndAges[1].name);
    }
}