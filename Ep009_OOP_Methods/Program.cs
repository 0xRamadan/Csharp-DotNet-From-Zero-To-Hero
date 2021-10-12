using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep009_OOP_Methods_Part01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Task:
             * End user need to be able to input the tax theirself.
             * solution: just use static instead of const.
             * 
             * 
             * hint: if there is an instance we call it by the object name like -> e1.FName
             * but if there is a static or const we call it by the class name like -> Employee.TAX
             * 
             * Another formal way:
             * INSTANCE METHOD IS CALLED BY OBJECT
             * STATIC METHOD IS CALLED BY TYPENAME
             * 
             * 
             * Difference Between static and constant:
             * 
             * CONSTANT: is a promise that CAN NOT be changed after it has been initialized.
             * 
             * STATIC MEMBER is a shared variable that  CAN be changed after it has been initialized.
             * 
            */
            Employee[] emps = new Employee[2];

            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("First Employee");
            Console.Write("Enter first Name: ");
            e1.FName = Console.ReadLine();

            Console.Write("Enter last Name: ");
            e1.LName = Console.ReadLine();

            Console.Write("wage: ");
            e1.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("logged Hours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;

            // e2
            Console.WriteLine("\nSecond Employee");
            Console.Write("Enter first Name: ");
            e2.FName = Console.ReadLine();

            Console.Write("Enter last Name: ");
            e2.LName = Console.ReadLine();

            Console.Write("wage: ");
            e2.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("logged Hours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());
            emps[1] = e2;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.PrintSlip());
            }
             
            Console.Read();
        }
    }
}
