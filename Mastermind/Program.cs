using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            Console.WriteLine("Welcome to Baby's First Mastermind Scheme!");
            // I added the line below for testing and proof of concept that the numbers are indeed randomized for each instance. You may comment it out at your leisure.
            Console.WriteLine($"COMBINATION FOR TESTING: {numbers.GetAllLockDigits()}");

            numbers.Instructions();

            numbers.Continue();

            int tryCount = 10;
            while (tryCount > 0)
            {
                numbers.NumberGuess();
                tryCount--;
                Console.WriteLine($"{tryCount} tries remaining!");

                numbers.Continue();
            }

            Console.WriteLine("Can't say I'm surprised. You failed!");
            numbers.Continue();
        }
    }
}