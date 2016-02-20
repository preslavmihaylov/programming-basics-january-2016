using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        
        int right = n / 2;
        int left = n / 2;
        if (n % 2 == 0)
        {
            left--;
        }

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col >= left && col <= right)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write('-');
                }
            }
            left--;
            right++;
            Console.WriteLine();
        }

        if (n % 2 == 1)
        {
            Console.WriteLine(new string('*', n));
        }

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0 || col == n - 1)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}