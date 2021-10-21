using System;

namespace Ep21_Inheritance
{
    public class Manager:Employee
    {
        private const decimal AllowenceRate= 0.05m;

        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        private decimal CalculateAllowence()
        {
            return AllowenceRate * base.Calculate();
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowence();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n Allowence: {Math.Round(CalculateAllowence(), 2):N0}$" +
                $"\n Net Salary: {Math.Round(this.Calculate(), 2):N0}$";
        }
    }

}
