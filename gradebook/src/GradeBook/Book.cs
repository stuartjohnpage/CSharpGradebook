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

            public void AddGrade (double grade) 
            {
                grades.Add(grade);
            }

            public Stats GetStats() 
            {
                var result = new Stats();
                result.Average = 0.0;
                result.High = double.MinValue;
                result.Low = double.MaxValue;
                result.Sum = 0.0;

            
            foreach(double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Sum += grade;
            }
            result.Average = result.Sum / grades.Count;

            return result;

            }
          
    }
}