using System;

namespace Ep21_Inheritance
{
    public class Employee
    {
        // constants
        private const int MinimumLoggedHours = 176;
        private const decimal OverTimeRate = 1.25m;

        // constructor
        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }

        private decimal CalculateBaseSalary()
        {
            return Wage * LoggedHours;
        }
        private decimal CalculateOverTimeRate()
        {
            var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? (LoggedHours - MinimumLoggedHours) : 0);
            return additionalHours * Wage * OverTimeRate;
        }

        // Virtual method to be able to override this method in other derived classes.
        protected virtual decimal Calculate()
        {
            
            return CalculateBaseSalary() + CalculateOverTimeRate();
        }

        // override on ToString() method
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Ep21_Inheritance.", "");
            return $"{type}" +
                $"\n Id: {Id}" +
                $"\n Name: {Name}" +
                $"\n Logged Hours: {LoggedHours} hrs" +
                $"\n Wage:{Wage} $/hr" +
                $"\n Base Salary: {Math.Round(CalculateBaseSalary(), 2):N0}$" +
                $"\n Overtime: {Math.Round(CalculateOverTimeRate(), 2):N0}$";

         }
    }

}
