//CHANGE HISTORY
//DATE          DEVELOPER          DESCRIPTION       
//2019-01-26    jmsnmrtn           FILE CREATION FOR Employee class
//

namespace P411
{
    internal class Employee
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        private decimal monthlySalary;
        public int numOfMonths = 12;//REMOVES NEED FOR MAGIC NUMBER

        public Employee(string firstName, string lastName, decimal salary)
            //THIS WAS LARGELY BASED OFF OF THE EXAMPLE CODE FROM CHAPTER 4 Account 4 PROGRAM.
            //IVE ADDED A FEW THINGS LIKE CALCULATING THE YEARLY SALARY AS WELL AS THE RAISE PERCENTAGE.
            //AND MAKING SURE IT UPDATES ALL THE VALUES CORRECTLY AFTER THE RAISE.
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
                if (value > 0.00m)
                {
                    monthlySalary = value;
                }
            }
        }
        public void Raise(decimal theRate)
        {
            if (theRate > 0.00m)
            {
                MonthlySalary = (MonthlySalary * theRate) + MonthlySalary;
                YearlySalary = MonthlySalary * numOfMonths;
            }
        }
        public decimal YearlySalary { get; private set; }
    }
}   