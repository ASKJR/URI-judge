using System;

class URI
{
    /*  
     *  Problem: Decora o Rolê!
     *  beecrowd | 3307 
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double area, radius;
        
        for (int i = 0; i < N; i++)
        {
            area = double.Parse(Console.ReadLine());
            radius = Math.Sqrt(area/12.56);
            if (radius < 12)
            {
                Console.WriteLine(String.Format("vermelho = R$ {0:0.00}", area * 0.09));
            } 
            else if (radius >= 12 && radius <= 15)
            {
                Console.WriteLine(String.Format("azul = R$ {0:0.00}", area * 0.07));
            }
            else
            {
                Console.WriteLine(String.Format("amarelo = R$ {0:0.00}", area * 0.05));
            }
        }
    }
}
