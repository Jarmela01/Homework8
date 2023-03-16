using System;

namespace Homework_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Shemoiyvanet Radiusis Parametri: ");
            double radiusi = Convert.ToDouble(Console.ReadLine());
            Square(radiusi);
        }

        static void Square(double a)
        {
            double square1;
            double square2;
            square2 = (a + a) * (a + a);
            square1 = (a*a*2);

            double fartobebisSxvaoba = square2 - square1;

            Console.WriteLine($"Fartobebs Shoris Sxvaobaa: {fartobebisSxvaoba}");
        }
    }
}
