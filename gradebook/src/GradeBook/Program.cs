using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //still strongly typed, but the compiler can figure it out
            var book = new Book("Stuart's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.AddGrade(56.1);
            var stats = book.GetStats();
            System.Console.WriteLine($"The sum is {stats.Sum:N1}.");
            System.Console.WriteLine($"The average is {stats.Average:N1}.");
            System.Console.WriteLine($"The high grade is {stats.High:N1}.");
            System.Console.WriteLine($"The high grade is {stats.Low:N1}.");

        }
    }
}