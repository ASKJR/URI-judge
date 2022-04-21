using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    /*  
     *  Problem: Camisetas
     *  beecrowd | 1258
     *  Solution developed by: Alberto Kato
     */


    public class Student
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{Color} {Size} {Name}";
        }
    }

    static void Main(string[] args)
    {
        int count = 0;
        while(true)
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 0) break;

           

            List<Student> students = new List<Student>();
            string name;
            string[] colorSize;
            
            for (int i = 0; i < N; i++)
            {
                name = Console.ReadLine();
                colorSize = Console.ReadLine().Split(' ');
                students.Add(new Student { Name = name, Color = colorSize[0], Size = colorSize[1]});
            }
            
            students = students
                .OrderBy(s => s.Color, StringComparer.Ordinal)
                .ThenByDescending(s => s.Size, StringComparer.Ordinal)
                .ThenBy(s => s.Name, StringComparer.Ordinal)
                .ToList();
            if (count > 0) Console.WriteLine();
            
            ++count;

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

        }

    }

}