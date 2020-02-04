using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ben's Grade Book");

            while(true)
            {
                Console.WriteLine("Please enter your grades, when you are finished, please type Q");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message Message);
                }
                finally
                {
                    Console.WriteLine("**")
                }
            };
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
