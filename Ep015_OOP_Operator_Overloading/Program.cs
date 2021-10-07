using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep015_OOP_Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Def.: Operator Overloading is a user defined type that can overload predefined Operators.

            Money m1 = new Money(19);
            Money m2 = new Money(10);

            Money m3 = m1 + m2;
            Money m4 = m1 - m2;

            Console.WriteLine($"Money m1: ${m1.Amount}, Money m2: ${m2.Amount}");
            Console.WriteLine($"Money m3: ${m3.Amount}");
            Console.WriteLine($"Money m4: ${m4.Amount}");

            Console.WriteLine(m4 > m3);
            Console.WriteLine(m4 <= m3);
            Console.WriteLine($"++m4 = {(++m4).Amount}");

            Console.ReadKey();
        }
    }

    public class Money
    {

        private decimal amount; // field
        public decimal Amount => amount; // Property -- get readonly

        // constructor
        public Money(decimal value)
        {
            this.amount = value;
        } 

        // operator overloading

        // + operator.
        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.Amount + money2.Amount;
            return new Money(value);
        }

        // - operator.
        public static Money operator -(Money money1, Money money2)
        {
            var value = money1.Amount - money2.Amount;
            return new Money(value);
        }

        // < and > operator must be defined together.
        public static bool operator >(Money money1, Money money2)
        {
            return money1.Amount > money2.Amount;
        }
        public static bool operator <(Money money1, Money money2)
        {
            return money1.Amount < money2.Amount;
        }

        // >= and < = operator must be defined together.
        public static bool operator >=(Money money1, Money money2)
        {
            return money1.Amount >= money2.Amount;
        }
        public static bool operator <=(Money money1, Money money2)
        {
            return money1.Amount <= money2.Amount;
        }

        // == and != operator must be defined together.
        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Amount == money2.Amount;
        }
        public static bool operator !=(Money money1, Money money2)
        {
            return money1.Amount != money2.Amount;
        }

        // unary operator like ++ or -- takes one argument
        public static Money operator ++(Money money)
        {
            var value = money.Amount;
            return new Money(++value);
        }
        public static Money operator --(Money money)
        {
            var value = money.Amount;
            return new Money(--value);
        }
    }
}
