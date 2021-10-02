using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep009_OOP_Methods_Part02
{
    class Program
    {
        static void Main(string[] args)
        {




            Demo d1 = new Demo();
            int age = 18;
            // caller
            d1.DoSomething(age); // age here is called an argument passed.
            Console.WriteLine(age); // ->  18
            Console.ReadLine();
            //  it's 18 because here we pass a copy of the actual parameter's value
            // and this is called PASS BY VALUE: MEANS YOU ARE MAKING A COPY IN MEMORY OF THE ACTUAL PARAMETER'S VALUE, THAT IS PASSED IN.


            // Console.WriteLine(ref age); // -> 21 // this is called PASS BY REFERENCE
            // you should put the 'ref' keyword at the caller and callee's parameter.









            /*
                  // One of The Ways to use 'out' keyword: 
             
            var numstring = "23211g";
            int number;
            if(!int.TryParse(numstring, out number))
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine($"you provided a vaild number {number}");
            }
             
            Console.ReadKey();
             
             */









            // work on overloading
            Demo d2 = new Demo();
            d2.Promote(100, "Egypt-Paris-Egypt");
            Console.ReadKey();






            // work on local vs public and the use of Expression body method
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Demo d3 = new Demo();
            d3.PrintEvens(numbers);




        }
    }

    public class Demo
    {
        // Method Syntax(Simple form)
        // <AccessModifier> <DataType>/Void MethodName (<Parameter List>)
        // {
        //      // series of statment
        // }


        // callee
        // here age is called Parameter
        public void DoSomething(int age)
        {
            age = 90;
            age = age + 3;
            Console.WriteLine("Do Something...");
        }

        // difference between out and ref keywords:
        // ref: the agrument passed must be initialied.
        // out: there must be an initialized parameter inside the method.



        // Method Signature (Name + Param type + param order)
        // if two Methods have the same Signature the C# compiler will give you an error.
        /* 
         * 
         * 
         // this will throw an error
         // method 1
        public void DoSomething(int x, double y)
        {
            
        }


         // method 2
        public void DoSomething(int x, double y)
        {

        }

         
         */


        // Method Overloading (A common way of implementing Polymorphism)

        // example: Company Promotions
        // 1. Promotion
        // 2. Promotion + Plane Ticket
        // 3. Promotion + Plane Ticket + Hotel accommodation


        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promotion of ${amount}");
        }
        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and trip {trip}");
        }
        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and trip {trip} and a hotle {hotel}");
        }




        // Expression body method


        /*
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        */

        // we use this as long as it just one simple return line.

        // this is an example between local and public method 
        public bool IsEven(int number) => number % 2 == 0;


        // local method
        public void PrintEvens(int[] orginals)
        {
            foreach (var num in orginals)
            {
                if (IsEvenNumber(num))
                {
                    Console.Write(num + " ");
                }
            }
            // this is a local method
            bool IsEvenNumber(int number) => number % 2 == 0;
            
        }

        // static method 
        // static member can only deal with static member

    }
}
