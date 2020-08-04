using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            string anotherRound;

            PrimeNumbers test = new PrimeNumbers();

            Console.WriteLine($"Let's locate some primes!\n\nThis application will find you any prime, in order, from first prime number on.");

            while (keepLooping)
            {
                Console.Write("\nWhich prime number are you looking for?");
                int userInput = Int32.Parse(Console.ReadLine());

                int nth = test.GetPrime(userInput);

                Console.WriteLine($"\nThe number {userInput} prime is {nth}.");
                do
                {
                    Console.WriteLine($"\nDo you want to find another prime number? (y/n):");
                    anotherRound = Console.ReadLine().ToLower();
                    if (anotherRound == "n")
                    { keepLooping = false; }
                    else if (anotherRound == "y")
                    { continue; }
                    else
                    {
                        Console.WriteLine("That is not a valid choice. Select y or n ");
                    }
                } while (anotherRound != "y" && anotherRound != "n"); 
            }
        }
    }
}
