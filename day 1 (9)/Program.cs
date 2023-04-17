using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 16.55e-3;
        double y = -2.75;
        double z = 0.15;

        double b = Math.Sqrt(10) * Math.Pow(Math.Pow(x, 3) + Math.Pow(x, y) + 2, 0.5)
                   * (Math.Pow(Math.Asin(z), 2) - x - y);

        Console.WriteLine(b); // -40.63069
    }
}
