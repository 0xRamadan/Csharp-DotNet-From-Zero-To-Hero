using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep013_OPP_Delegates
{
    // create a delegate to multicaste two method -- Rectangle example.
    // delegate must be the same signature as the method that point to.
    public delegate void RectDelegate(decimal width, decimal height);

    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee {Id= 1, FullName = "Ahmed Foaad", Gender = "M", TotalSales = 60000m},
                new Employee {Id= 2, FullName = "Mahmoud Waleed", Gender = "M", TotalSales = 53000m},
                new Employee {Id= 3, FullName = "Mohamed Yaseen", Gender = "M", TotalSales = 59000m},
                new Employee {Id= 4, FullName = "Sama Ahmed", Gender = "F", TotalSales = 78000m},
                new Employee {Id= 5, FullName = "Nour Ehab", Gender = "F", TotalSales = 26000m},
                new Employee {Id= 6, FullName = "Yasmin Hazem", Gender = "F", TotalSales = 15000m},
                new Employee {Id= 7, FullName = "Yosuf ElSayed", Gender = "M", TotalSales = 35000m},
                new Employee {Id= 8, FullName = "Jamila Fathy", Gender = "F", TotalSales = 49000m}
            };

            // creating an instance of the class Report
            var report = new Report();


            // Method approach
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------", IsGrOrEQ60000);
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------", IsBetWeen30000And60000);
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------", IsLessThan30000);



            // Delegate approach -- this approach using annoymous delegate (NOT Best Practice)
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------",
                delegate (Employee e) { return e.TotalSales >= 60000m; } );
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------", 
                delegate (Employee e) { return e.TotalSales >= 30000m && e.TotalSales < 60000m; });
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------", 
                delegate (Employee e) { return e.TotalSales < 30000m; } );


            // Delegate approach -- this approach using annoymous delegate (Best Practice)
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------",
                e => e.TotalSales >= 60000m);
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------",
                e => e.TotalSales >= 30000m && e.TotalSales < 60000m);
            report.ProcessEmployee(emps, "Employees Sales Report", "---------------------------",
                e => e.TotalSales < 30000m);


            // working on Multicast Delegate -- Rectangle exmaple.
            Console.WriteLine("working on Multicast Delegate -- Rectangle exmaple.");
            Console.WriteLine("-----------------------------");
            var rectangle = new Rectangle();
            // creating an object of delegate
            RectDelegate rect;
            // making delegate points to GetArea method -- one method
            rect = rectangle.GetArea;
            // making delegate points to GetPerimeter method -- two method
            rect += rectangle.GetPerimeter;

            // this line will run the two method
            rect(10, 10);

            // subtraction GetArea Method
            rect -= rectangle.GetArea;

            Console.WriteLine("\nafter subtraction GetArea Method\n");
            rect(10, 10);

            Console.ReadKey();
        }


        // Method approach -- conditions

        // this way was been using in .net core 2 before Annonymous Delegate (No need for Method approach)
        static bool IsGrOrEQ60000(Employee e) => e.TotalSales >= 60000m;
        static bool IsBetWeen30000And60000(Employee e) => e.TotalSales >= 30000m && e.TotalSales < 60000m;
        static bool IsLessThan30000(Employee e) => e.TotalSales < 30000m;

    }
}
