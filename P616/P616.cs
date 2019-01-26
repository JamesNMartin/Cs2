//CHANGE HISTORY
//DATE          DEVELOPER          DESCRIPTION       
//2019-01-26    jmsnmrtn           FILE CREATION FOR p616 AND CREATED PROGRAM MAIN METHOD
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 6.16 (Displaying a Bar Chart) One interesting application of computers is to display graphs and bar charts. Write an app that reads three numbers between 1 and 30. For each number that’s read, your app should display the same number of adjacent asterisks. For example, if your app reads the number 7, it should display: *******
 * 
 */

namespace P616
{
    class P616
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
    ____  _            __            _                         
   / __ \(_)________  / /___ ___  __(_)___  ____ _   ____ _    
  / / / / / ___/ __ \/ / __ `/ / / / / __ \/ __ `/  / __ `/    
 / /_/ / (__  ) /_/ / / /_/ / /_/ / / / / / /_/ /  / /_/ /     
/_____/_/____/ .___/_/\__,_/\__, /_/_/ /_/\__, /   \__,_/      
    ____    /_/         ___//////        /____/__              
   / __ )____ ______   / ____/ /_  ____ ______/ /_             
  / __  / __ `/ ___/  / /   / __ \/ __ `/ ___/ __/             
 / /_/ / /_/ / /     / /___/ / / / /_/ / /  / /_               
/_____/\__,_/_/      \____/_/ /_/\__,_/_/   \__/  

How to use: 
This program is designed to show a bar graph with the * symbol.
You will be prompted to enter three numbers. These numbers need to be whole
numbers within a range of 1 - 30. 

The output will look like this:

5 *****
12 ************
8 ********
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
");
            //INPUT SECTION
            //GETTING THE FIRST NUMBER FROM USER
            Console.Write("Pick your first number (1 - 30): ");
            int firstInt = int.Parse(Console.ReadLine());

            //GETTING SECOND NUMBER FROM USER
            Console.Write("Pick your second number (1 - 30: ");
            int secondInt = int.Parse(Console.ReadLine());

            //GETTING THIRD NUMBER FROM USER
            Console.Write("Pick your third number (1 - 30: ");
            int thirdInt = int.Parse(Console.ReadLine());

            if (firstInt >= 1 && firstInt <= 30)//CHECKING IF USERS NUMBER IS IN THE NUMBER RANGE OF 1-30
            {
                Console.WriteLine($"{firstInt} {PrintAsterisk(firstInt)}");//SENDS TO PRINT THE ASTERISKS
            }
            else
            {
                Console.WriteLine("Error: Not in the correct range");
            }
            if (secondInt >= 1 && firstInt <= 30)//CHECKING IF USERS NUMBER IS IN THE NUMBER RANGE OF 1-30
            {
                Console.WriteLine($"{secondInt} {PrintAsterisk(secondInt)}");//SENDS TO PRINT THE ASTERISKS
            }
            else
            {
                Console.WriteLine("Error: Not in the correct range");
            }
            if (thirdInt >= 1 && firstInt <= 30)//CHECKING IF USERS NUMBER IS IN THE NUMBER RANGE OF 1-30
            {
                Console.WriteLine($"{thirdInt} {PrintAsterisk(thirdInt)}");//SENDS TO PRINT THE ASTERISKS
            }
            else
            {
                Console.WriteLine("Error: Not in the correct range");
            }
        }
        static string PrintAsterisk(int input)//PRINTING THE NUMBER OF ASTERISKS FROM INPUT
        {
            string output = "";
            while (input > 0)
            {
                input--;
                output += "*";
            }
            return output;
        }
    }
}
