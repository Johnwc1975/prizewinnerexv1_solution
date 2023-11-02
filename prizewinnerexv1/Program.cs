//namespace prizewinnerexv1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
using System;

using System.Collections.Generic;

using System.Linq;

class Program

{

    static void Main()

    {

        Console.WriteLine("Enter the number of winners (X):");

        int numberOfWinners = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of prizes (Y):");

        int numberOfPrizes = int.Parse(Console.ReadLine());

        if (numberOfWinners < numberOfPrizes)

        {

            Console.WriteLine("The number of winners cannot be less than the number of prizes.");

            return;

        }

        List<string> contestants = new List<string>();

        Dictionary<string, int> winners = new Dictionary<string, int>();

        for (int i = 1; i <= numberOfWinners; i++)

        {

            Console.Write($"Enter the name of winner {i}: ");

            string contestant = Console.ReadLine();

            contestants.Add(contestant);

            winners[contestant] = 0; // Initialize the count of prizes for each contestant to 0

        }

        Random random = new Random();

        while (winners.Sum(w => w.Value) < numberOfPrizes)

        {

            int index = random.Next(0, contestants.Count);

            string winner = contestants[index];

            if (winners[winner] < 1)

            {

                winners[winner]++; // Increase the count of prizes for the winner

                Console.WriteLine($"{winner} has won a prize.");

            }

        }

        Console.WriteLine("\nList of winners:");

        foreach (var winner in winners.Keys)

        {

            Console.WriteLine(winner);

        }

    }

}