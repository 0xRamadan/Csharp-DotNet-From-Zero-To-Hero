using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep016_OPP_Finalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Garbge Collector: Automatic Memory Management
            /*
             * When Object get Disposed(Destroyed)??
             * 1. End of Program Execution (implicit)
             * 2. Memory Full (implicit)
             * 3. Garbge Collector (explict)
             */

            {
                // scope 1
                var p = new Person();
                p.Name = "Ali";
            }

            MakeSomeGarbge();
            Console.WriteLine($"Memory before collection: {GC.GetTotalMemory(false)}");
            GC.Collect();
            Console.WriteLine($"Memory after collection: {GC.GetTotalMemory(true)}");
            Console.ReadKey();
        }

        static void MakeSomeGarbge()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }

    class Person
    {
        // property
        public string Name { get; set; }


        // constructor
        public Person()
        {
            Console.WriteLine("this is a constructor");
        }

        // Deconstructor:  be called when the object disposed/ destroyed
        ~Person()
        {
            Console.WriteLine("this is a constructor");
        }
    }
}
