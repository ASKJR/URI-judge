using System;

class URI
{
    /*  
     *  Problem: Lendo Livros
     *  beecrowd | 1542
     *  Solution developed by: Alberto Kato
     */

    static void Main(string[] args)
    {
        string[] input;
        string pluralCase;
        float Q, D, P;
        int output;

        while (true)
        {
            input = Console.ReadLine().Split(' ');
            if (input[0] == "0") break;
            Q = float.Parse(input[0]);
            D = float.Parse(input[1]);
            P = float.Parse(input[2]);
            output = (int)(((P * D) / (P - Q)) * Q);
            pluralCase = output > 1 ? " paginas" : " pagina";
            Console.WriteLine(output + pluralCase);
        }
    }
}