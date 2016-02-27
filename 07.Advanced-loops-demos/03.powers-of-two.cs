using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int num = 1;
        for (int cnt = 0; cnt <= n; cnt++)
        {
            Console.WriteLine(num);
            num *= 2;
        }

    }
}