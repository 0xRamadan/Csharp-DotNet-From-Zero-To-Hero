using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep022_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // for learning purposes
            Honda honda = new Honda("Honda", "sportage", 2014);
            honda.Move();
            Caterpiller caterpiller = new Caterpiller("caterpiller", "giller", 2020);
            caterpiller.Move();
            caterpiller.Load();

            IMaintenanceCaterpiller maintenanceCaterpiller = new Caterpiller("caterpiller two", "giller 2", 2019);
            maintenanceCaterpiller.Maintenance(); // will call the method in IMaintenanceCaterpiller interface



            // real world example
            Console.WriteLine("\n------------------------\n");

            Cashier cashierObject = new Cashier(new Cash());
            cashierObject.Checkout(89564.32m);
            Cashier cashierObject01 = new Cashier(new Visa());
            cashierObject01.Checkout(1352.25m);
            Cashier cashierObject02 = new Cashier(new MasterCard());
            cashierObject02.Checkout(4659.65m);





            Console.ReadKey();
        }
    }

    class Cashier 
    {
        private IPayment _payment;

        public Cashier(IPayment payment)
        {
            _payment = payment;
        }
        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }
    }

    interface IPayment
    {
        void Pay(decimal amount);
    }

    class Cash : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"cash amount: ${Math.Round(amount, 2):N0}"); // $9,999.99
        }
    }
    class Visa : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Vias: ${Math.Round(amount, 2):N0}"); 
        }
    }
    class MasterCard : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"MasterCard: ${Math.Round(amount, 2):N0}");
        }
    }
    class Debit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit: {Math.Round(amount, 2):N0}"); 
        }
    }

}
