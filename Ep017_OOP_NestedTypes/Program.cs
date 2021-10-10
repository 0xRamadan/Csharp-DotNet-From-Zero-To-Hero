using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep017_OOP_NestedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                NestedTypes: it is a type defined within a class(type).
            
             */

            Employee e1 = new Employee();
            Console.WriteLine(e1.EmployeeInsurance.CompanyName);
            Console.ReadKey();
        }
    }


    // Nested Type 
    // it is good for 
    // 1. does not pollute the golbal scope.
    // 2. the methods of B implicity have access to private members

    class A
    {
        private int x;

        class B
        {
            // method
            void someMethod()
            {
                A a = new A();
                // here, you can access private members in this class, as long as this class within the parent(container) class A.
                a.x = 10;

            }
        }
    }

    // another example 

    // Composition: is type of relationship between Classes -- (Car has a Motor) 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Insurance EmployeeInsurance { get; set; }

        public Employee() =>
            EmployeeInsurance = new Insurance { PolicyId = -1, CompanyName = "N/A" };
    }

    class Insurance
    {
        public int PolicyId { get; set; }
        public string CompanyName { get; set; }
    }

    class Deparment
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
