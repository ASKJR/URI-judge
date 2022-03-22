using System;
using System.Linq;

class URI
{
    /*  
     *  Problem: Rodízio Veicular
     *  beecrowd | 2712
     *  Solution developed by: Alberto Kato
     */


    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());
        for (int i = 0; i < n; i++)
        {
            string vehicleId = Console.ReadLine().Trim();
            string[] vehicleIdSplited = vehicleId.Split('-');
            if (vehicleIdSplited[0].All(char.IsLetter) 
                && vehicleIdSplited[0].All(char.IsUpper)
                && vehicleIdSplited[0].Length == 3
                && vehicleIdSplited[1].All(char.IsDigit)
                && vehicleIdSplited[1].Length == 4) 
            {

                string weekDay = "";
                char vehicleNumberLastChar = vehicleIdSplited[1][vehicleIdSplited[1].Length - 1];
                if (vehicleNumberLastChar == '1' || vehicleNumberLastChar == '2') weekDay = "MONDAY";
                if (vehicleNumberLastChar == '3' || vehicleNumberLastChar == '4') weekDay = "TUESDAY";
                if (vehicleNumberLastChar == '5' || vehicleNumberLastChar == '6') weekDay = "WEDNESDAY";
                if (vehicleNumberLastChar == '7' || vehicleNumberLastChar == '8') weekDay = "THURSDAY";
                if (vehicleNumberLastChar == '9' || vehicleNumberLastChar == '0') weekDay = "FRIDAY";
                Console.WriteLine(weekDay);
            }
            else
            {
                Console.WriteLine("FAILURE");
            }
        }
    }
}