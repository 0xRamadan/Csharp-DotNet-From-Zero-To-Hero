using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep009_OOP_Methods_Part01
{ 
    public class Employee
    {
        // <AccessModifier> public, private, protected
        // Constant  -> <AccessModifier> const <DataType> <FieldName> = <Value>;

        public static double TAX = 0.03;

        // <AccessModifier> public, private, protected
        // Fields  -> <AccessModifier> <DataType> <FieldName> = <InitialValue>;

        public string FName;
        public string LName;
        public double wage;
        public double LoggedHours;
        public double NetSalary;

        // as long this method you only use them inside this class, it's a good practice to use them as private methods instead of public
        private double Calculate() => wage * LoggedHours;
        private double CalculateTax() => Calculate() * TAX;
        private double CalculateNet() => Calculate() - CalculateTax();

        public string PrintSlip()
        {
            return $"\nFirst Name: {FName}" +
                    $"\nLast Name: {LName}" +
                    $"\nWage: {wage}" +
                    $"\nLogged Hours: {LoggedHours}" +
                    "\n -----------------------------------" +
                    $"\nSalary before TAX: ${Calculate()}" +
                    $"\nDeductable TAX ({TAX * 100}%) Amount: ${CalculateTax()}" +
                    $"\nNet Salary: ${CalculateNet()}";
        }
    }
}
