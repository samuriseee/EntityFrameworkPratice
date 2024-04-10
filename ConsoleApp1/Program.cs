using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var students = context.Students.Where(s => s.Department == "CNTT" && s.Age >= 18 && s.Age <= 20).ToList();

                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
                }
            }
        }
    } 
}


