using System;

class LiveDemo
{
    static void Main()
    {
        int minNumber = int.MaxValue;
        int lineCount = int.Parse(Console.ReadLine());

        for (int cnt = 0; cnt < lineCount; cnt++)
        {
            int number = int.Parse(Console.ReadLine());

            if (minNumber > number)
            {
                minNumber = number;
            }
        }

        Console.WriteLine(minNumber);
    }
}