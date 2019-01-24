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
            Random rand = new Random();
            int randomInt = rand.Next(1000);
            Console.WriteLine(randomInt);
        }
    }
}
