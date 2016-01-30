using System;

class LiveDemo
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());
        string sourceMeasure = Console.ReadLine();
        string destMeasure = Console.ReadLine();

        double coefficient = 0;

        if (sourceMeasure == "km")
        {
            coefficient = 0.001;
        }
        else if (sourceMeasure == "m")
        {
            coefficient = 1;
        }
        else if (sourceMeasure == "cm")
        {
            coefficient = 100;
        }
        else if (sourceMeasure == "mi")
        {
            coefficient = 0.000621371192;
        }
        else if (sourceMeasure == "in")
        {
            coefficient = 39.3700787;
        }
        else if (sourceMeasure == "mm")
        {
            coefficient = 1000;
        }
        else if (sourceMeasure == "ft")
        {
            coefficient = 3.2808399;
        }
        else if (sourceMeasure == "yd")
        {
            coefficient = 1.0936133;
        }

        double metres = value / coefficient;

        if (destMeasure == "km")
        {
            coefficient = 0.001;
        }
        else if (destMeasure == "m")
        {
            coefficient = 1;
        }
        else if (destMeasure == "cm")
        {
            coefficient = 100;
        }
        else if (destMeasure == "mi")
        {
            coefficient = 0.000621371192;
        }
        else if (destMeasure == "in")
        {
            coefficient = 39.3700787;
        }
        else if (destMeasure == "mm")
        {
            coefficient = 1000;
        }
        else if (destMeasure == "ft")
        {
            coefficient = 3.2808399;
        }
        else if (destMeasure == "yd")
        {
            coefficient = 1.0936133;
        }

        metres *= coefficient;
        Console.WriteLine("{0} {1}", metres, sourceMeasure);
    }
}