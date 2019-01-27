//CHANGE HISTORY
//DATE          DEVELOPER          DESCRIPTION       
//2019-01-26    jmsnmrtn           FILE CREATION FOR Employee class (SOME WHAT. IT WAS PROVIDED FOR US)
//2019-01-26    jmsnmrtn           ADDED COMMENTS AND FIXED YEARLY SALARY CALCULATION TO REFLECT A RAISE TO ANY EMPLOYEE

namespace P411
{
    internal class Employee
    {
        public string FirstName { get; set; }//GET AND SET FIRST NAME
        public string LastName { get; set; }//GET AND SET LAST NAME
        private decimal monthlySalary;//CREATE MONTHLY VARIABLE
        public int numOfMonths = 12;//REMOVES NEED FOR MAGIC NUMBER

        public Employee(string firstName, string lastName, decimal salary)//THE MEAT AND POTATOES OF THE EMPLOYEE CLASS. SETTING ALL ASSIGNED VALUES
            //THIS WAS LARGELY BASED OFF OF THE EXAMPLE CODE FROM CHAPTER 4 Account 4 PROGRAM.
            //IVE ADDED A FEW THINGS LIKE CALCULATING THE YEARLY SALARY AS WELL AS THE RAISE PERCENTAGE.
            //AND MAKING SURE IT UPDATES ALL THE VALUES CORRECTLY AFTER THE RAISE.
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = salary;
            YearlySalary = MonthlySalary * numOfMonths;
        }
        public decimal MonthlySalary//SETTING MONTHLY SALARY
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
        public void Raise(decimal theRate)//APPLY RAISE TO EMPLOYEE
        {
            if (theRate > 0.00m)
            {
                MonthlySalary = (MonthlySalary * theRate) + MonthlySalary;
                YearlySalary = MonthlySalary * numOfMonths;//SETTING THE YEARLY RATE BASED ON THE MONTHLY MULTIPLIED BY THE NUMBER OF MONTHS
                                                           //THIS IS NEEDED HERE BECAUSE WE NEED TO UPDATE THE YEARLY AFTER THE RAISE IS APPLIED
                                                           //OTHERWISE IT WILL BE INCORRECT.
            }
        }
        public decimal YearlySalary { get; private set; }//GET AND SET YEARLY SALARY
    }
}   