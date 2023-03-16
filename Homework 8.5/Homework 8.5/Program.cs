using System;
using System.Collections.Generic;

namespace Homework_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> point = new List<int>();
            var symbol = ' ';
            for (int i = 0; i < i+1; i++)
            {
                Console.Write("Shemoiyvane Dgevandeli Shedegi: ");
                int dayResult = Convert.ToInt32(Console.ReadLine());
                point.Add(dayResult);
                Console.WriteLine("Ciklis Dasasruleblad Sheiyvane 0, Gasagrdzeleblad Ki Nebismieri Simbolo.");
                if (dayResult == 0)
                {
                    break;
                }
            }

            Result(point);
        }

        static void Result(List<int> a)
        {
            int result = 0;

            for (int i = 1; i < a.Count; i++)
            {

                if (a[i] > a[i-1])
                {
                    result++;
                }
                else
                {
                    result = result;
                }

            }

            Console.WriteLine($"Result: {result}");


        }
    }
}
