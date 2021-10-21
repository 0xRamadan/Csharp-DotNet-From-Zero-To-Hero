using System;

namespace Ep21_Inheritance
{
    public class Sales : Employee
    {

        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal salesVolume, decimal commission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesVolume;
            this.Commission = commission;
        }
        private decimal CalculateBouns()
        {
            return SalesVolume * Commission;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n Bouns: {Math.Round(CalculateBouns(), 2):N0}$" +
                $"\n Commission: {Math.Round(Commission, 2):N0}$" +
                $"\n Net Salary: {Math.Round(this.Calculate(), 2):N0}$";
        }
    }

}
