using System;
using System.Collections.Generic;

namespace Homework_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Symbols: ");
            var symbols = Console.ReadLine();
            Jackpot(symbols);

        }

        static void Jackpot(string a)
        { 
            List<char> numbers = new List<char>();

            int count = 1;

            foreach (var item in a)
            {
                numbers.Add(item);
            }
            for (int i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    ++count;
                }
                else
                {
                    --count;
                }
                
            }
            if (numbers.Count == count)
            {

                Console.WriteLine("Congratulations, You Won!");

            }
            else
            {
                Console.WriteLine("Game Over!");
            }


        }

    }
}
