using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep010_OPP_Constructor
{
    class Program
    {
        // working with Date
        static void Main(string[] args)
        {
            // Working with Constructor
            // one of the main purpose of Constructor -> Initialization -> giving an initial value to a variable.

            // def: Modeling is to convert problem to class is anything that represent something.


            // creating an object of the class and give it initial values using constructor method
            Date d1 = new Date(28, 2, 1999);

            // regular way to give values to fields
           /* d1.Day = 01;
            d1.Month = 01;
            d1.Year = 0001;*/

            Console.WriteLine(d1.GetDate());
            Console.ReadKey();

        }

        // working with Object Initializer part 01 -- Employee class
        static void Main2(string[] args)
        {
            // work with Object Initializer

            // one way of creating an object of a class
            Employee emp1 = new Employee();
            emp1.Id = 13;
            emp1.FName = "Ramy";
            emp1.LName = "Tamer";

            // another way of creating an object of a class
            Employee emp2 = new Employee()
            {
                Id = 12,
                FName = "Ahmed",
                LName = "Amir"
            };

            // using a constructor method while initializing an object of a class.
            Employee emp3 = new Employee(16)
            {
                FName = "karim",
                LName = "gamal"
            };

            Console.WriteLine(emp3.DisplayEmployeeDetail());
        }


        // working withd Object Initializer part 02 -- EmployeePrivate class
        static void Main3(string[] args)
        {
            EmployeePrivate emp4 = EmployeePrivate.Create(100, "Hazem", "Yousef");
            Console.WriteLine(emp4.DisplayEmployeeDetail());
            Console.ReadKey();
        }
    }


    // Main1 - work with Constructor, Constructor Overloading, readonly, private vs public, validation of Date
    public class Date
    {
        // you can only modifiy the readonly field inside the constructor.
        // عشان محدش يلعب فيهم→ readonly              // 0, 1,  2,  3,  4,  5,  6,  7,  8,  9,  10, 11, 12
        private static readonly int[] DaysToMonths365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DaysToMonths366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        // good practice here if the field is public → first letter is Capital, if the field is private → first letter is small.
        // public int DayInMonth;
        // private int dayInMonth;
        // or
        // private int _dayInMonth;

        /*public int Day;
        public int Month;
        public int Year;*/

        // if you are gonna use a constructor and give the values while creating the object,
        // you should use the field as private, to prevent the user to do this → ex: d1.day =10;
        // the values here are just a defualt value incase of wrong input values.
        // and using readonly to add more layer of security.
        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;


        // Constructor Syntax
        // <Accessmodifier> <TypeName>(<Parameters list>)
        //{
        //      series of statement
        //}


        // Constructor
        public Date(int day, int month, int year)
        {
            // Validation the Date
            // to check if the year is leap or not.
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            // to validate the constrains of the year and the month
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                // first you need to know if it's a leap year or not to decide which array you're gonna choose. -> line 31 or 32.
                int[] days = isLeap ? DaysToMonths366 : DaysToMonths365;
                if (day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }

                // commented the else statment because a defualt value already has been given at the initialization of the field.
                /*else
                {
                    // reset {default values}
                    this.day = 01;
                    this.month = 01;
                    this.year = 0001;
                }*/
            }
            /*else
            {
                // reset {default values}
                this.day = 01;
                this.month = 01;
                this.year = 0001;
            }*/
        }

        // Overloading the Constructor
        public Date(int year) : this(01, 01, year)
        {

        }
        public Date(int month, int year) : this(01, month, year)
        {

        }

        // a public method to get the date
        public string GetDate()
        {
            return $"{this.day.ToString().PadLeft(2, '0')}/{this.month.ToString().PadLeft(2, '0')}/{this.year.ToString().PadLeft(4, '0')}";
        }
    }

    // Main2 - work with Object Initializer
    public class Employee
    {
        // to create a constructor in a fast way → type 'ctor' then double tap.
       public Employee()
        {

        }
        public Employee(int id)
        {
            this.Id = id;
        }

        // creating fields
        public int Id;
        public string FName;
        public string LName;

        // create a method to display employe details
        public string DisplayEmployeeDetail()
        {
            return $"Name: {FName} {LName}\nId: {Id}";
        }
    }
    
    // Main3 - working with Object Initializer with private constructor
    public class EmployeePrivate
    {
        // private constructor
        private EmployeePrivate()
        {

        }
        // overload on private constructor
        private EmployeePrivate(int id, string fname, string lname)
        {
            this.id = id;
            this.fName = fname;
            this.lName = lname;
        }

        // creating fields
        private int id;
        private string fName;
        private string lName;

        // a method that return an employeePrivate --instance-- and it has to be static to be able to called by class name.
        public static EmployeePrivate Create(int id, string fname, string lname)
        {
            return new EmployeePrivate(id, fname, lname);
        }

        public string DisplayEmployeeDetail()
        {
            return $"Name: {fName} {lName}\nId: {id}";
        }
    }
}
