using System;
using System.Collections.Generic;

class URI
{
    /*  
     *  Problem: System of a Download
     *  beecrowd | 2582
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] ids;
        int code;
        Dictionary<int,string> musics = new Dictionary<int, string> {
            {0 ,  "PROXYCITY"},
            {1 ,  "P.Y.N.G."},
            {2 ,  "DNSUEY!"},
            {3 ,  "SERVERS"},
            {4 ,  "HOST!"},
            {5 ,  "CRIPTONIZE"},
            {6 ,  "OFFLINE DAY"},
            {7 ,  "SALT"},
            {8 ,  "ANSWER!"},
            {9 ,  "RAR?"},
            {10,  "WIFI ANTENNAS"},
        };   
        for (int i = 0; i < N; i++)
        {
            ids = Console.ReadLine().Split(' ');
            code = int.Parse(ids[0]) + int.Parse(ids[1]);
            Console.WriteLine(musics[code]);
        }
    }
}