using System;

class LiveDemo
{
    static void Main()
    {
        int a, b, oldB;
        for (a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()); 
            a % b != 0; 
            oldB = b,
            b = a % b,
            a = oldB);

        Console.WriteLine(b);
    }
}