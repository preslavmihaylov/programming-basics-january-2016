using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        while (n != 0)
        {
            int digit = Math.Abs(n % 10);
            sum += digit;
            n /= 10;
        }

        Console.WriteLine(sum);

    }
}