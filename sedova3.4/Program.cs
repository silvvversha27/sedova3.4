using System;

namespace sedova3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("|      x      |       y      |");
                for (double x = -1; x <= 15; x += 0.2)
                {
                    double y = 0;
                    if (x < 2.8) y = -Math.Sin(x);
                    else if (x > 3.8) y = 5 * x * Math.Log(Math.Abs(1 + x));
                    else y = Math.Pow(Math.E, (Math.Pow(-x, 2)) + 2);
                    Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}