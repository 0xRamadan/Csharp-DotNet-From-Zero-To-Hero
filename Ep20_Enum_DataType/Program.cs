using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep20_Enum_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum is a Strongly Typed named constants
            // Enum is a Type → Value type which indicate that it is → less memory
            // Enum is
            //         1. less memory
            //         2. readablity
            //         3. easy to use




            // to parse and get the value 
            Console.WriteLine((int)(MONTH.APR));
            Console.WriteLine((int)Enum.Parse(typeof(MONTH), "FEB"));
            Console.WriteLine("----------------------------");



            // try parse
            var day1 = "FEB";
            if( Enum.TryParse(day1, out MONTH month))
            {
                Console.WriteLine(month);
                Console.WriteLine("----------------------------");

            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }




            // working with IsDefined
            var day2 = 2;
            if (Enum.IsDefined(typeof(MONTH), day2))
            {
                Console.WriteLine((MONTH)day2);
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }



            // looping on Enum -- GetNames
            foreach (var m in Enum.GetNames(typeof(MONTH)))
            {
                Console.WriteLine($"{m} = {(int)Enum.Parse(typeof(MONTH), m)}");
            }
            Console.WriteLine("----------------------------");

            // looping on Enum -- GetValues
            foreach (var m in Enum.GetValues(typeof(MONTH)))
            {
                Console.WriteLine($"{m} = {(int)m}");
            }
            Console.WriteLine("----------------------------");



            // working with flags example
            var day = (DAY.SATURDAY | DAY.SUNDAY);
            if (day.HasFlag(DAY.WEEKEND))
            {
                Console.WriteLine("enjoy your weekend! ");
                Console.ReadKey();
            }
        }
    }


    enum MONTH // : long  // you can explicitly specify any other integral numeric type → Defualt: Int
    {
        // They start with zeros and increase by one follow the text editor

        JAN = 1,
        FEB, 
        MAR, 
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DES
    }

    // Flags Enum
    [Flags]
    enum DAY
    {
        NONE         = 0b_0000_0000, // 0
        MONDAY       = 0b_0000_0001, // 1
        TUESDAY      = 0b_0000_0010, // 2
        WEDNESDAY    = 0b_0000_0100, // 4
        THURSDAY     = 0b_0000_1000, // 8
        FRIDAY       = 0b_0001_0000, // 16 
        SATURDAY     = 0b_0010_0000, // 32
        SUNDAY       = 0b_0100_0000, // 64
        BUSINESSDAYS = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,
        WEEKEND      = SATURDAY | SUNDAY

    }
}
