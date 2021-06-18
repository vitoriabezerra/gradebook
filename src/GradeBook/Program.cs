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
            
            
            while(true){
                Console.WriteLine("Enter a grade or 'q' to exit");
                var input = Console.ReadLine();
                Console.WriteLine();

                if(input == "q")
                {
                    break; //caso o input seja q, ele irá dar break e sair do loop do while
                }
            try
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(FormatException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally //piece of code that you always want to execute
            {
                Console.WriteLine("**");
            }

            }
            
            var stats = book.GetStatistics();


            System.Console.WriteLine($"The Average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The Lowest grade is {stats.Low}");
            System.Console.WriteLine($"The Average grade is {stats.High}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}