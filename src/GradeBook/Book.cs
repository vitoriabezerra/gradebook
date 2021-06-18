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


        public void AddLetterGrade(char letterGrade)
        {
            switch (letterGrade)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                case 'E':
                    AddGrade(50);
                    break;

                default:
                    AddGrade(0);
                    break;

            }
        }
        public void AddGrade(double grade){
            if(grade>=0 && grade<=100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
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
            result.High = Math.Max(grades[index], result.High);
            index++;
           }while(index < grades.Count);

           result.Average /= grades.Count;

           switch(result.Average) //switch case with pattern matching
           {
               case var d when d >=90.0:
                    result.Letter = 'A';
                    break;

               case var d when d >=80.0:
                    result.Letter = 'B';
                    break;
                    
                case var d when d >=70.0:
                    result.Letter = 'A';
                    break;
                case var d when d >=60.0:
                    result.Letter = 'A';
                    break; 

                default:
                    result.Letter = 'F';
                    break; 

           }

           return result;
        }
    }
}