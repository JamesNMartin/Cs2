//CHANGE HISTORY
//DATE          DEVELOPER          DESCRIPTION       
//2019-01-26    jmsnmrtn           FILE CREATION FOR p411 AND CREATED PROGRAM MAIN METHOD
//                                 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4.11 (Employee Class) Create a class called Employee that includes three pieces of information as either instance variables or auto-implemented properties—a first name (type string), a last name (type string) and a monthly salary (decimal). Your class should have a constructor that initializes the three values. Provide a property with a get and set accessor for any instance variables. If the monthly salary is negative, the set accessor should leave the instance variable unchanged. Write a test driver for Employee that demonstrates class Employee’s capabilities (use P411.cs for this). Create two Employee objects and display each object’s yearly salary. Then give each Employee a 10% raise and display each Employee’s yearly salary again.
 * 
 *
 */

namespace P411
{
    class P411
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    ______                __                         ________               
   / ____/___ ___  ____  / /___  __  _____  ___     / ____/ /___ ___________
  / __/ / __ `__ \/ __ \/ / __ \/ / / / _ \/ _ \   / /   / / __ `/ ___/ ___/
 / /___/ / / / / / /_/ / / /_/ / /_/ /  __/  __/  / /___/ / /_/ (__  |__  ) 
/_____/_/ /_/ /_/ .___/_/\____/\__, /\___/\___/   \____/_/\__,_/____/____/  
               /_/            /____/                                         

How to use:
The first two employees are created for you. Each are given a first and last
name as well as a monthly salary. The raise for the first two employees are 
set to 10% as per the assignment. The yearly salary is calculated in the 
Employee class and can be got by using XXXX.YearlySalary where XXXX is your 
variable. You will be prompted to create a third employee and will need to 
set the first name, last name, monthly salary, and the raise percentage 
you would like to give him/her.


* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
");
            decimal raisePercentage = 0.10m;
            Console.WriteLine("Employee #1");
            Employee emp1 = new Employee("Hugh", "Honey", 4500.00m);
            Console.WriteLine($"{emp1.FirstName} {emp1.LastName}'s monthly salary is ${emp1.MonthlySalary} before the raise.");
            Console.WriteLine($"{emp1.FirstName} {emp1.LastName}'s yearly salary is ${emp1.YearlySalary} before the raise.");
            emp1.Raise(raisePercentage);
            Console.WriteLine($"{emp1.FirstName} {emp1.LastName}'s monthly salary is ${emp1.MonthlySalary} After the raise.");
            Console.WriteLine($"{emp1.FirstName} {emp1.LastName}'s yearly salary is ${emp1.YearlySalary} After the raise.");

            Console.WriteLine(@"
#####################################################################################################
");
            Console.WriteLine("Employee #2");
            Employee emp2 = new Employee("Vic", "Vinegar", 3000.00m);
            Console.WriteLine($"{emp2.FirstName} {emp2.LastName}'s monthly salary is ${emp2.MonthlySalary} before the raise.");
            Console.WriteLine($"{emp2.FirstName} {emp2.LastName}'s yearly salary is ${emp2.YearlySalary} before the raise.");
            emp2.Raise(raisePercentage);
            Console.WriteLine($"{emp2.FirstName} {emp2.LastName}'s monthly salary is ${emp2.MonthlySalary} After the raise.");
            Console.WriteLine($"{emp2.FirstName} {emp2.LastName}'s yearly salary is ${emp2.YearlySalary} After the raise.");

            Console.WriteLine(@"
#####################################################################################################
");
            //ADDING CUSTOM EMPLOYEE
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your monthly salary: ");
            decimal monthlySalary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter raise percentage: (Ex. .10, 0.20, etc...) ");
            decimal selfSetRaise = decimal.Parse(Console.ReadLine());

            Console.WriteLine(@"
#####################################################################################################
");
            Console.WriteLine("Employee #3");
            Employee emp3 = new Employee(firstName, lastName, monthlySalary);
            Console.WriteLine($"{emp3.FirstName} {emp3.LastName}'s monthly salary is ${emp3.MonthlySalary} before the raise.");
            Console.WriteLine($"{emp3.FirstName} {emp3.LastName}'s yearly salary is ${emp3.YearlySalary} before the raise.");
            emp3.Raise(selfSetRaise);//SHOWING THAT DIFFERENT RATES WORK
            Console.WriteLine($"{emp3.FirstName} {emp3.LastName}'s monthly salary is ${emp3.MonthlySalary} After the {selfSetRaise * 100}% raise.");
            Console.WriteLine($"{emp3.FirstName} {emp3.LastName}'s yearly salary is ${emp3.YearlySalary} After the {selfSetRaise * 100}% raise.");
        }
    }
}
