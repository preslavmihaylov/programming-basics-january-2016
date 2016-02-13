using System;

class LiveDemo
{
    static void Main()
    {
        int maxNumber = int.MinValue;
        int lineCount = int.Parse(Console.ReadLine());

        for (int cnt = 0; cnt < lineCount; cnt++)
        {
            int number = int.Parse(Console.ReadLine());

            if (maxNumber < number)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine(maxNumber);
    }
}