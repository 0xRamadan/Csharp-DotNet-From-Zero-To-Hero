using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep21_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager(1000, "Ahmed Elsayed", 180, 50);

            Maintainance maintainance = new Maintainance(1001, "Amr Ahmed", 186, 8);

            Sales sales = new Sales(1002, "Karim Elsayed", 176, 10, 0.05m, 10000m);

            Developer developer = new Developer(1003, "Ramadan", 190, 30, true);


            Employee[] employees = { manager, maintainance, sales, developer };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("--------------------------------");

            }


            Console.ReadKey();
        }
    }


}
