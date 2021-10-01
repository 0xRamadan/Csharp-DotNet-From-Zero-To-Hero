using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008withEngEssam
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack: stores the object
            // while heap: stores the value of the object

            // Object (Instance)Syntax;
            // Declaration <Type> <ObjectName>;
            // Assignment <ObjectName> = new <Type>();
            // Initializatoin <Type> <ObjectName> = New <Type>();
            Employee[] emps = new Employee[2];

            Employee e1 = new Employee();
            Employee e2 = new Employee();

            /*            for (int i = 0; i < emps.Length; i++)
                        {

                            Console.Write("Enter first Name: ");
                            emps[i].FName = Console.ReadLine();

                            Console.Write("Enter last Name: ");
                            emps[i].LName = Console.ReadLine();

                            Console.Write("wage: ");
                            emps[i].wage = Convert.ToDouble(Console.ReadLine());

                            Console.Write("logged Hours: ");
                            emps[i].LoggedHours = Convert.ToDouble(Console.ReadLine());


                        }*/

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
                var netSalary = emp.wage * emp.LoggedHours - (emp.wage * emp.LoggedHours * Employee.TAX);

                Console.WriteLine($"First Name: {emp.FName}");
                Console.WriteLine($"Last Name: {emp.LName}");
                Console.WriteLine($"Wage: {emp.wage}");
                Console.WriteLine($"Logged Hours: {emp.LoggedHours}");
                Console.WriteLine($"Net Salary: {netSalary}");
            }

            Console.Read();


        }
    }
}
