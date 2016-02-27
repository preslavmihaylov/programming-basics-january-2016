using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int first = 1;
        int second = 1;

        for (int cnt = 2; cnt <= n; cnt++)
        {
            int oldSecond = second;
            second = first + second;
            first = oldSecond;
        }

        Console.WriteLine(second);
    }
}