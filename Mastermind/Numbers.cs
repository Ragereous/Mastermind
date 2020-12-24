using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class Numbers
    {
        public int LockDigitOne { get; set; }
        public int LockDigitTwo { get; set; }
        public int LockDigitThree { get; set; }
        public int LockDigitFour { get; set; }

        private readonly Random newRandomNumber = new Random();

        public int RandomNumber(int min, int max)
        {
            return newRandomNumber.Next(min, max);
        }

        public Numbers()
        {
            LockDigitOne = RandomNumber(1, 7);
            LockDigitTwo = RandomNumber(1, 7);
            LockDigitThree = RandomNumber(1, 7);
            LockDigitFour = RandomNumber(1, 7);
        }

        public int GetAllLockDigits()
        {
            return Convert.ToInt32("" + LockDigitOne + LockDigitTwo + LockDigitThree + LockDigitFour);
        }

        public void Instructions()
        {
            Console.WriteLine("\nYou've got ten (10) tries to open my four digit combination lock. Enter your guesses in numerical format one at a time when prompted. (1, 2, 3, 4, etc.) I won't let you know if you've gotten the combination wrong, giving an incorrect digit will not be marked. However, I'll be generous enough to let you know if a number is right with a '-' but you won't know which position it should be in. Numbers that are correct and in the right position will be marked with '+'. Keep it interesting by trying not to die!\n");
        }

        public void NumberGuess()
        {
            string responseOne = null;
            string responseTwo = null;
            string responseThree = null;
            string responseFour = null;

            Console.Write("Enter combination lock number 1/4: ");
            int userGuess, userGuessOne; 
            userGuess = userGuessOne = Convert.ToInt32(Console.ReadLine());
            if (userGuess == LockDigitOne)
            {
                responseOne = "+";
            }
            else if (userGuess == LockDigitTwo)
            {
                responseOne = "-";
            }
            else if (userGuess == LockDigitThree)
            {
                responseOne = "-";
            }
            else if (userGuess == LockDigitFour)
            {
                responseOne = "-";
            }
            else
            {
                responseOne = " ";
            }

            Console.Write("\nEnter combination lock number 2/4: ");
            int userGuessTwo;
            userGuess = userGuessTwo = Convert.ToInt32(Console.ReadLine());
            if (userGuess == LockDigitTwo)
            {
                responseTwo = "+";
            }
            else if (userGuess == LockDigitOne)
            {
                responseTwo = "-";
            }
            else if (userGuess == LockDigitThree)
            {
                responseTwo = "-";
            }
            else if (userGuess == LockDigitFour)
            {
                responseTwo = "-";
            }
            else
            {
                responseTwo = " ";
            }

            Console.Write("\nEnter combination lock number 3/4: ");
            int userGuessThree;
            userGuess = userGuessThree = Convert.ToInt32(Console.ReadLine());
            if (userGuess == LockDigitThree)
            {
                responseThree = "+";
            }
            else if (userGuess == LockDigitOne)
            {
                responseThree = "-";
            }
            else if (userGuess == LockDigitTwo)
            {
                responseThree = "-";
            }
            else if (userGuess == LockDigitFour)
            {
                responseThree = "-";
            }
            else
            {
                responseThree = " ";
            }

            Console.Write("\nEnter combination lock number 4/4: ");
            int userGuessFour;
            userGuess = userGuessFour = Convert.ToInt32(Console.ReadLine());
            if (userGuess == LockDigitFour)
            {
                responseFour = "+";
            }
            else if (userGuess == LockDigitOne)
            {
                responseFour = "-";
            }
            else if (userGuess == LockDigitTwo)
            {
                responseFour = "-";
            }
            else if (userGuess == LockDigitThree)
            {
                responseFour = "-";
            }
            else
            {
                responseFour = " ";
            }

            int userAnswer;
            userAnswer = Convert.ToInt32("" + userGuessOne + userGuessTwo + userGuessThree + userGuessFour);
            string winCheck = responseOne + responseTwo + responseThree + responseFour;
            Console.WriteLine($"\nYour guess: {userAnswer} / {responseOne}{responseTwo}{responseThree}{responseFour}\n");

            ExitCondition(winCheck);
        }

        public void ExitCondition(string winCheck)
        {
            string winCondition = "++++";

            if (winCheck == winCondition)
            {
                Console.WriteLine("Congratulations, you managed to survive!");
                Continue();
                Environment.Exit(0);
            }
        }

        public void Continue()
        {
            Console.WriteLine("\nPress Enter to continue.\n");
            Console.ReadKey();
        }
    }
}