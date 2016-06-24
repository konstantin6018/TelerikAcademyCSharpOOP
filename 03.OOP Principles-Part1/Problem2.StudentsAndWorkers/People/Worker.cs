namespace Problem2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName, string secondName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Salary cant be negative!");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0 || value> 24)
                {
                    throw new Exception("Workhours cant be negative!");
                }
                this.workHoursPerDay = value;
            }
        }
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour;

            moneyPerHour = (weekSalary / (workHoursPerDay * 5));

            return moneyPerHour;
        }
    }
}
