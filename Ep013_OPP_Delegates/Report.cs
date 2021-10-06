using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep013_OPP_Delegates
{
    class Report
    {
        // def: Delegate object  that points to method  
        // create a delegate
        public delegate bool IllegiblesSales(Employee e);

        // method to process employees -- last parameter form type delegate
        public void ProcessEmployee(Employee[] employees , 
                                    string title ,
                                    string seperatorType ,
                                    IllegiblesSales isIllegilbe)
        {
            Console.WriteLine(title);
            Console.WriteLine(seperatorType);

            foreach (var e in employees)
            {
                if (isIllegilbe(e))
                {
                    Console.WriteLine($"{e.Id} | {e.FullName} | {e.Gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
