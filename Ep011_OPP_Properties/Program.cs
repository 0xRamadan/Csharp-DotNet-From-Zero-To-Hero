using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep011_OPP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance or an object of Dollar class and give it initial value using Constructor
            Dollar dollar = new Dollar(1.99m);
            Console.WriteLine(dollar.Amount); //get
            Console.ReadKey();
        }
    }

    // def: Property is a public way to access private field.
    public class Dollar
    {

        // creating private field
        private decimal _amount;

        // automatic property
        public decimal Amount { get; set; }

        // regular property
        public decimal AmountDollar
        {
            get
            {
                return this._amount;
            }
            // this is a private set
            private set
            {
                this._amount = ProcessAmount(value);
            }
        }

        public bool IsZero => _amount == 0;


        // this is a property with an initial value without using set and this will lead that this is just readonly property.
        public decimal ConversionFactor { get; } = 1.99m;

        public Dollar(decimal amount)
        {
            this._amount = ProcessAmount(amount);
        }

        // a validation method to check the amount 
        private decimal ProcessAmount(decimal value) => value <= 0 ?  0 : Math.Round(value, 2);


    }


}
