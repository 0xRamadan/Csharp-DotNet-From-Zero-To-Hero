using System;

namespace Ep21_Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;
        private bool TaskCompleted { get; set; }
        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskCompletd) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskCompletd;
        }

        private decimal CalculateBouns()
        {
            if (TaskCompleted)
                return base.Calculate() + Commission;
            return 0;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBouns();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n Task Completed: {(TaskCompleted? "yes": "no")}"+
                $"\n Bouns: {Math.Round(CalculateBouns(), 2):N0}$" +
                $"\n Net Salary: {Math.Round(this.Calculate(), 2):N0}$";
        }
    }

}
