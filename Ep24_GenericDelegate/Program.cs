using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep24_GenericDelegate
{
    // create delegate
    // public delegate bool Filter<in T>(T n);

    // Generic Delegate
    // Func<>
    // action<>
    // predicate<>

    class Program
    {
        static void Main(string[] args)
        {

            // create integer list
            IEnumerable<int> list1 = new int[] { 1, 2, 3, 6, 9, 48, 12, 3, 10, 24, 22, 78, 5, 15 };

            PrintNumber<int>(list1, n => n < 8, () => Console.WriteLine("numbers less than 8"));
            PrintNumber<int>(list1, n => n < 25, () => Console.WriteLine("numbers less than 25"));
            PrintNumber<int>(list1, n => n %2 == 0, () => Console.WriteLine("Even Numbers"));

            // create decimal list
            IEnumerable<decimal> list2 = new decimal[] { 1.23m, 2.256m, 3.49m, 6.49m, 9.49m, 48.15m, 12.49m, 3.34m, 10.89m, 24.48m, 22.12m, 78.2m, 5.5m, 15.6m };

            PrintNumber<decimal>(list2, n => n > 6.5m, () => Console.WriteLine("number bigger than 6.5m: "));

            Console.ReadKey();    
        }

        static void PrintNumber<T>(IEnumerable<T> numbers, Predicate<T> predicate, Action action)
        {
            action();
            foreach (var n in numbers)
            {
                
                if (predicate(n))
                {
                    Console.WriteLine(n);
                }
            }
        }

        /*static void PrintNumber<T>(IEnumerable<T> numbers, Filter<T> filter)
        {
            foreach (var n in numbers)
            {
                if (filter(n))
                {
                    Console.WriteLine(n);
                }
            }
           
        }*/
    }
}
