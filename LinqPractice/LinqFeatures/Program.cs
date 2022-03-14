using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//remove this namespace solves the problem where the compiler finds two overloads of the count
//method : one from System.Linq and one from LinqFeatures.Features
//using LinqFeatures.Features;

namespace LinqFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee{Id = 1, Name = "Gianni" },
                new Employee{Id = 4, Name = "Francesca"}
            };

            Employee[] employees = new Employee[]
            {
                new Employee{Id = 1, Name = "Sorin"},
                new Employee{Id = 2, Name = "Chris"}
            };

            List<Employee> emplList = new List<Employee>()
            {
                new Employee{Id = 3, Name = "Gianni"}
            };

            IEnumerable<Employee> emplEnumList = new List<Employee>()
            {
                new Employee{Id = 5, Name = "Sara"}
            };
            Console.WriteLine(developers.Count());
        }
    }
}
