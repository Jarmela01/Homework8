using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = new List<string>()
            { "Hello", "World", "Programming", "Communication" };
            Console.Write("Gtxovt Shemoiyvanot Sigrdze: ");
            int length = Convert.ToInt32(Console.ReadLine());
            ElementLength(elements, length);
        }

        static void ElementLength(List<string> a,int b)
        {

            var element = from s in a
                          where s.Length == b
                          select s;
            if (element.Any())
            {
                foreach (var item in element)
                {
                    Console.WriteLine($"Mag Sigrdzis Elementia: {item}");
                }
                
            }
            else
            {
                Console.WriteLine("No Result!");
            }
                          
                

        }
    }
}
