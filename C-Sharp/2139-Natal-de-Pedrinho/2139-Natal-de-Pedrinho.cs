using System;

class URI
{
    /*  
     *  Problem: Natal de Pedrinho
     *  beecrowd | 2139
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        DateTime currentDay;
        DateTime christmasDay = new DateTime(2016, 12, 25);
        string dateInput;
        while ((dateInput = Console.ReadLine()) !=null)
        {
            string[] dateInputArr = dateInput.Split(' ');
            currentDay = new DateTime(2016, int.Parse(dateInputArr[0]), int.Parse(dateInputArr[1]));
            int daysDifference = (christmasDay.Date - currentDay.Date).Days;
            if (daysDifference < 0)
                Console.WriteLine("Ja passou!");
            else if (daysDifference == 0)
                Console.WriteLine("E natal!");
            else if (daysDifference == 1)
                Console.WriteLine("E vespera de natal!");
            else
                Console.WriteLine("Faltam {0} dias para o natal!", daysDifference);
        }
    }
}