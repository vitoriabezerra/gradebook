using System;
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


            var index =0;
            do
           {
            result.Average += grades[index];
            result.Low = Math.Min(grades[index], result.Low);
            result.Low = Math.Max(grades[index], result.High);
            index++;
           }while(index < grades.Count);
           
           result.Average /= grades.Count; 
           return result;
        }
    }
}