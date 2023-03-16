using System;

namespace Homework_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mogeba: ");
            int win = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fre: ");
            int draw = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lost: ");
            int lost = Convert.ToInt32(Console.ReadLine());
            Point(win, draw, lost);



        }

        static void Point(int a, int b, int c)
        {
            int points = 0;
            for (int i = 0; i < a; i++)
            {
                points += 3;
            }
            for (int i = 0; i < b; i++)
            {
                points++;
            }

            Console.WriteLine($"Tqveni Gundis Saerto Qulebia: {points}");
        }
    }
}
