//CHANGE HISTORY
//DATE          DEVELOPER          DESCRIPTION       
//2019-01-26    jmsnmrtn           p730 CREATED PROGRAM MAIN METHOD
//2019-01-26    jmsnmrtn           ADDED SOME CONSOLE GUI AND ADDED MORE COMMENTS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 7.30 (Guess-the-Number Game) Write an app that plays “guess the number” as follows: Your app chooses the number to be guessed by selecting a random integer in the range 1 to 1000. The app displays the prompt "Guess a number between 1 and 1000: ". The player inputs a first guess. If the player’s guess is incorrect, your app should display Too high. Try again. or Too low. Try again. to help the player “zero in” on the correct answer. The app should prompt the user for the next guess. When the user enters the correct answer, display Congratulations. You guessed the number! and allow the user to choose whether to play again. [Note: The guessing technique employed in this problem is using a similar strategy to a binary search, which is discussed in Chapter 18
 */

namespace P730
{
    class P730
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
   ______                           __  __               _   __                __                 
  / ____/_  _____  __________      / /_/ /_  ___        / | / /_  ______ ___  / /_  ___  _____    
 / / __/ / / / _ \/ ___/ ___/_____/ __/ __ \/ _ \______/  |/ / / / / __ `__ \/ __ \/ _ \/ ___/    
/ /_/ / /_/ /  __(__  |__  )_____/ /_/ / / /  __/_____/ /|  / /_/ / / / / / / /_/ /  __/ /        
\________,_/\___/____/____/      \__/_/ /_/\___/     /_/ |_/\__,_/_/ /_/ /_/_.___/\___/_/         
  / ____/___ _____ ___  ___                                                                       
 / / __/ __ `/ __ `__ \/ _ \                                                                      
/ /_/ / /_/ / / / / / /  __/                                                                      
\____/\__,_/_/ /_/ /_/\___/                                                                       
                                                                                                  

How to use: 
This program is designed to have the user guess a randomly picked number from 1 - 1000. After
every guess the program will tell you whether you are too high or too low. When you guess the 
number correctly you will see a message saying you have won. After you win you will be prompted
if you would like to play again. For yes you press 1 then ENTER, if no you would press 2 then 
ENTER.

Good luck!

* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
");
            Game();//CALL GAME TO START GAME. DOING THIS MADE IT EASIER TO PLAY AGAIN WHEN THE USER WINS.
        }
        static void Game()
        {
            Random rand = new Random();
            int randomInt = rand.Next(1, 1000);//RANDOM INT FROM 1-1000
            bool game = true;//MAKING THE GAME LIVE
            Console.Write("Guess a number between 1 and 1000: ");
            while (game == true)
            {
                //GET USER GUESS
                int guess = int.Parse(Console.ReadLine());
                if (guess == randomInt)//WINNING THE GAME
                {
                    Console.WriteLine("*** Congratulations! You guessed the number! ***");
                    game = false;//MAKING CURENT GAME UNACTIVE, BECAUSE OF USER WIN.
                    Console.Write("Play again? y[1] n[2] + ENTER: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Game();//CALLING GAME TO RUN AGAIN
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");//PROGRAM EXITING
                    }
                }
                else if (guess < randomInt)//GUESS WAS TOO LOW
                {
                    Console.Write("too low, guess again: ");
                }
                else if (guess > randomInt)//GUESS WAS TOO HIGH
                {
                    Console.Write("too high, guess again: ");
                }
            }
        }
    }
}
