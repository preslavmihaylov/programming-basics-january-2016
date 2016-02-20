using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 1; col <= n * 4 + n; col++)
            {
                if (col > n * 2 && col < n * 2 + n + 1)
                {
                    if (row == ((n - 1) / 2))
                    {
                        Console.Write('|');   
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    // Logic for middle
                }
                else
                {
                    // Logic for glasses part
                    if (row == 0 || row == n - 1)
                    {
                        Console.Write('*');
                    }
                    else if (col == 1 || col == n * 2)
                    {
                        Console.Write('*');
                    }
                    else if (col == (n * 2 + n + 1) || col == n * 4 + n)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('/');
                    }
                }
            }
            Console.WriteLine();
        }

    }
}