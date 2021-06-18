using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um novo objeto do tipo book
            Book book = new Book("Vitoria's Gradebook");
            book.AddGrade(48.9);
            book.AddGrade(67.9);
            book.AddGrade(98.9);
            var stats = book.GetStatistics();


            System.Console.WriteLine($"The Average grade is {stats.Average}");
            System.Console.WriteLine($"The Lowest grade is {stats.Low}");
            System.Console.WriteLine($"The Average grade is {stats.High}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}