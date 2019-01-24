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
            decimal raisePercentage = 0.10m;

            Employee emp1 = new Employee("James", "Martin", 50.00m);
            //Console.WriteLine(emp1.FirstName);
            //Console.WriteLine(emp1.LastName);
            //Console.WriteLine(emp1.MonthlySalary);
            Console.WriteLine($"The employee {emp1.FirstName} {emp1.LastName}'s yearly salary is {emp1.MonthlySalary} before the raise.");

            emp1.Raise(raisePercentage);

            Console.WriteLine($"The employee {emp1.FirstName} {emp1.LastName}'s yearly salary is {emp1.MonthlySalary} After the raise.");

            //TODO GET THE YEARLY SALARY TO WORK CORRECTLY.

            //Employee emp2 = new Employee("Steven", "McPiss", 60.00m);
            //Console.WriteLine(emp2.FirstName);
            //Console.WriteLine(emp2.LastName);
            //Console.WriteLine($"The employee {emp2.FirstName} {emp2.LastName}'s yearly salary is {emp2.YearlySalary} before the raise");
        }
    }
}
