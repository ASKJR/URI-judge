using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: Tradutor do Papai Noel
     *  beecrowd | 1763
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        Dictionary<string, string> christmasGreetingsByCountry = new Dictionary<string, string>()
        {
            {"brasil"         ,"Feliz Natal!"},
            {"alemanha"       ,"Frohliche Weihnachten!"},
            {"austria"        ,"Frohe Weihnacht!"},
            {"coreia"         ,"Chuk Sung Tan!"},
            {"espanha"        ,"Feliz Navidad!"},
            {"grecia"         ,"Kala Christougena!"},
            {"estados-unidos" ,"Merry Christmas!"},
            {"inglaterra"     ,"Merry Christmas!"},
            {"australia"      ,"Merry Christmas!"},
            {"portugal"       ,"Feliz Natal!"},
            {"suecia"         ,"God Jul!"},
            {"turquia"        ,"Mutlu Noeller"},
            {"argentina"      ,"Feliz Navidad!"},
            {"chile"          ,"Feliz Navidad!"},
            {"mexico"         ,"Feliz Navidad!"},
            {"antardida"      ,"Merry Christmas!"},
            {"canada"         ,"Merry Christmas!"},
            {"irlanda"        ,"Nollaig Shona Dhuit!"},
            {"belgica"        ,"Zalig Kerstfeest!"},
            {"italia"         ,"Buon Natale!"},
            {"libia"          ,"Buon Natale!"},
            {"siria"          ,"Milad Mubarak!"},
            {"marrocos"       ,"Milad Mubarak!"},
            {"japao"          ,"Merii Kurisumasu!"}
        };

        string country;

        while((country = Console.ReadLine()) != null)
        {
            if(christmasGreetingsByCountry.ContainsKey(country))
            {
                Console.WriteLine(christmasGreetingsByCountry[country]);
            }
            else
            {
                Console.WriteLine("--- NOT FOUND ---");
            }
        }
    }
}