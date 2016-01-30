using System;

class LiveDemo
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string sourceMeasure = Console.ReadLine();
        string destMeasure = Console.ReadLine();

        double coefficient = 0;
        coefficient = GetCoefficient(sourceMeasure);
        double metres = value / coefficient;
        coefficient = GetCoefficient(destMeasure);
        metres *= coefficient;

        Console.WriteLine("{0} {1}", metres, sourceMeasure);
    }

    static double GetCoefficient(string metric)
    {
        double coefficient = 0;

        if (metric == "km")
        {
            coefficient = 0.001;
        }
        else if (metric == "m")
        {
            coefficient = 1;
        }
        else if (metric == "cm")
        {
            coefficient = 100;
        }
        else if (metric == "mi")
        {
            coefficient = 0.000621371192;
        }
        else if (metric == "in")
        {
            coefficient = 39.3700787;
        }
        else if (metric == "mm")
        {
            coefficient = 1000;
        }
        else if (metric == "ft")
        {
            coefficient = 3.2808399;
        }
        else if (metric == "yd")
        {
            coefficient = 1.0936133;
        }

        return coefficient;
    }
}