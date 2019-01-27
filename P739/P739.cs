//CHANGE HISTORY
//DATE          DEVELOPER          DESCRIPTION       
//2019-01-26    jmsnmrtn           p739 CREATED PROGRAM MAIN METHOD
//2019-01-26    jmsnmrtn           FINISHED UP ASSIGNMENT AND ADDED SOME COMMENTS TO CODE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 7.39 (Computer-Assisted Instruction) The use of computers in education is referred to as computer-assisted instruction (CAI). Write a program that will help an elementary-school student learn multiplication. Use a Random object to produce two positive one-digit integers. The program should then prompt the user with a question, such as

How much is 6 times 7?

The student then inputs the answer. Next, the program checks the student’s answer. If it is correct, display the message "Very good!" and ask another multiplication question. If the answer is wrong, display the message "No. Please try again." and let the student try the same question repeatedly until the student gets it right. A separate method should be used to generate each new question. This method should be called once when the app begins execution and each time the user answers the question correctly.
*/

namespace P739
{
    class P739
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
   ______                            __                  ___              _      __           __   
  / ____/___  ____ ___  ____  __  __/ /____  _____      /   |  __________(_)____/ /____  ____/ /   
 / /   / __ \/ __ `__ \/ __ \/ / / / __/ _ \/ ___/_____/ /| | / ___/ ___/ / ___/ __/ _ \/ __  /    
/ /___/ /_/ / / / / / / /_/ / /_/ / /_/  __/ /  /_____/ ___ |(__  |__  ) (__  ) /_/  __/ /_/ /     
\____/\____/_/ /_/ /_/ .___/\__,_/\__/\___/_/        /_/  |_/____/____/_/____/\__/\___/\__,_/      
    ____           _/_/                __  _                                                       
   /  _/___  _____/ /________  _______/ /_(_)___  ____                                             
   / // __ \/ ___/ __/ ___/ / / / ___/ __/ / __ \/ __ \                                            
 _/ // / / (__  ) /_/ /  / /_/ / /__/ /_/ / /_/ / / / /                                            
/___/_/ /_/____/\__/_/   \__,_/\___/\__/_/\____/_/ /_/                                                                                                                                                                                                     
How to use: 
This program is made to help students learn their single digit multiplication. This program will 
pick two random numbers that you then have to solve by simple multiplication. Your answer should 
be a whole number WITHOUT decimals.

Side note: On first launch and replaying the game it might take some time getting two random 
numbers. Had to put a check to make sure you wouldn't always get 1x1, 2x2, 3x3, etc...

* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
");
            Game();
        }
        static void Game()
        {
            bool gameInProgress = true;
            int randomIntOne = GenerateRandomInt();
            int randomIntTwo = GenerateRandomInt();
            while (randomIntOne == randomIntTwo)
                /*SADLY THIS WAS ONE OF THE ONLY WAYS I COULD ENSURE THAT I WOULDNT CONSTANTLY GET THE SAME NUMBER TWICE.
                SO SADLY YOU WILL NEVER GET A QUESTION LIKE 1x1, 2x2, 3x3, etc...*/
            {
                randomIntTwo = GenerateRandomInt();
            }
            int product = Calculate(randomIntOne, randomIntTwo);
            Console.Write($"What is {randomIntOne} times {randomIntTwo}? ");
            while (gameInProgress == true)//KEEPS THE GAME GOING WHILE THE USER IS TRYING TO GUESS THE ANSWER
            {
                int playerGuess = int.Parse(Console.ReadLine());
                if (playerGuess == product)
                {
                    Console.WriteLine("YOU WIN!");
                    gameInProgress = false;//ENDING THE GAME
                    Console.Write("Would you like to play again? y[1] n[2]: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Game();//RUN GAME AGAIN
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");//LEAVE GAME
                    }
                }
                else
                {
                    Console.Write($"No please try again, what is {randomIntOne} times {randomIntTwo}? ");
                }
            }
        }
        static int GenerateRandomInt()
        {
            Random rand = new Random(DateTime.Now.Millisecond);/* FOUND THE ANSWER HOW TO FIX GETTING THE SAME RANDOM NUMBER HERE: https://stackoverflow.com/a/33462155 */
            return rand.Next(0, 9);//RANDOM NUMBER BETWEEN 0 AND 9
        }
        static int Calculate(int i, int j)//CALCULATE THE PRODUCT OF THE TWO RANDOM NUMBERS TO COMPARE TO USER GUESS
        {
            return i * j;
        }
    }
}
