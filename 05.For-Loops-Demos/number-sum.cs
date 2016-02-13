using System;

class LiveDemo
{
    static void Main()
    {
        int lineCount = int.Parse(Console.ReadLine());
        int result = 0;

        for (int cnt = 0; cnt < lineCount; cnt++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            result += currentNumber;
        }

        Console.WriteLine(result);
    }
}