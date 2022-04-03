using System;

class URI
{
    /*  
     *  Problem: Nova Senha RA
     *  beecrowd | 2690
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string password;
        string encodedPass = "";

        for (int i = 0; i < n; i++)
        {
            
            password = Console.ReadLine().Replace(" ", "");
            
            foreach(char letter in password)
            {
                if ("GQaku".Contains("" + letter))
                {
                    encodedPass += "0"; 
                }
                else if("ISblv".Contains("" + letter))
                {
                    encodedPass += "1";
                }
                else if ("EOYcmw".Contains("" + letter))
                {
                    encodedPass += "2";
                }
                else if ("FPZdnx".Contains("" + letter))
                {
                    encodedPass += "3";
                }
                else if ("JTeoy".Contains("" + letter))
                {
                    encodedPass += "4";
                }
                else if ("DNXfpz".Contains("" + letter))
                {
                    encodedPass += "5";
                }
                else if ("AKUgq".Contains("" + letter))
                {
                    encodedPass += "6";
                }
                else if ("CMWhr".Contains("" + letter))
                {
                    encodedPass += "7";
                }
                else if ("BLVis".Contains("" + letter))
                {
                    encodedPass += "8";
                }
                else if ("HRjt".Contains("" + letter))
                {
                    encodedPass += "9";
                }
            }
            Console.WriteLine(encodedPass.Substring(0,12));
            encodedPass = "";
        }
    }
}