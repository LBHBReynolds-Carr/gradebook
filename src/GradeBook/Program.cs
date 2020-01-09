using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ben's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            
            var stats = book.GetStatistics();
        }
    }
}
