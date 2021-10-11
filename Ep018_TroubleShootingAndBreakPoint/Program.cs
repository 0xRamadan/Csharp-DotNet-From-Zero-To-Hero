using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep018_TroubleShootingAndBreakPoint
{
    // this lesson is just to talk about error types and a preview about breakpoint and how it works

    // Toubleshooting
    // 1. Syntax Error
    // 2. Runtime Error
    // 3. Logical Error

    // Syntax Error: Occur during development type mistake in code. → Red Squiggly Line


    // Runtime Error: occurs while execution the program due to Improper user inputs, improper design logic or system errors.

    // ** Execption: is an event, which occurs during the execution of a program,
    // that disrupts the normal flow of the program's instructions

    // to solve we use {try and catch and finaly(optional)}


    // Logical Error; Error occurs when the problem is written fine but it doesn't produce a desired result.

    class Program
    {
        static void Main(string[] args)
        {
            var f = ConvertCelsuisToFehrenhite(0);
            Console.WriteLine($"{0}C:{f}F");

            var c = ConvertFehrenhiteToCelsuis(32);
            Console.WriteLine($"{32}F:{c}C");
            Console.ReadKey();
        }

        static decimal ConvertCelsuisToFehrenhite(decimal celsuis)
        {
            var fehrenhite = 0m;
            fehrenhite = (celsuis * 9 / 5) + 32;
            return fehrenhite;
        }

        static decimal ConvertFehrenhiteToCelsuis(decimal fehrenhite)
        {
            var celsuis = 0m;
            celsuis = (fehrenhite - 32) * 5 / 9;
            return celsuis;
        }
    }
}
