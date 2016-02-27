using System;

class LiveDemo
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (a % b != 0)
        {
            // a --> b
            // b --> a % b
            int oldB = b;
            b = a % b;
            a = oldB;
        }

        Console.WriteLine(b);

    }
}