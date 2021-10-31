using System;

namespace Ep021_Inheritance
{
    public class Maintainance : Employee
    {
        private const decimal Hardship = 100m;
        public Maintainance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + Hardship;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n Hardship: {Math.Round(Hardship, 2):N0}$" +
                $"\n Net Salary: {Math.Round(this.Calculate(), 2):N0}$";
        }
    }


}
