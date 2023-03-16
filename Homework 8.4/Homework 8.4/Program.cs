using System;

namespace Homework_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] days = new int[7];
            Income(days);       
            
        }

        static void Income(int[] a)
        {
            int income = 0;
            int hours;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Please Enter Day {i + 1} Hours: ");
                hours = Convert.ToInt32(Console.ReadLine());
                a[i] = hours;              
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] <=8)
                {
                    income += a[i] * 10;
                }
                if (i >= 5)
                {
                    income += a[i] * 10;
                }
                if (a[i] > 8)
                {
                    income += a[i] * 10 - (a[i] - 8) * 5;
                }
                else
                {
                    income = income;
                }
                

                
            }

            Console.WriteLine($"Shemosavalia: {income}");
        }
    }
}
