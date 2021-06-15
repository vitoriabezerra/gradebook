using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade){
            if(grade>=0 && grade<=100)
            {
                grades.Add(grade);
            }
            else
            {
                System.Console.WriteLine("Grade is out of range");
            }
        }

        public Statistics GetStatistics(){

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue; //Smallest possible floating point value
            result.Low = double.MaxValue; //Largest possible floating point value

           foreach (var grade in grades)
           {
               result.Average += grade;

               if( grade > result.High )
               {
                   result.High = grade;
               }
               if( grade < result.Low )
               {
                   result.Low = grade;
               }

           }
           result.Average /= grades.Count; 
           return result;
        }
    }
}