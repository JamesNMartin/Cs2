namespace P411
{
    internal class Employee
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        private decimal monthlySalary;
        public int numOfMonths = 12;

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = salary;
            YearlySalary = MonthlySalary * numOfMonths;

        }
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            private set
            {
                if (value > 0.0m)
                {
                    monthlySalary = value;
                }
            }
        }
        public void Raise(decimal theRate)
        {
            if (theRate > 0.0m)
            {
                MonthlySalary = (MonthlySalary * theRate) + MonthlySalary;
            }
        }
        public decimal YearlySalary { get; private set; }
    }
}   