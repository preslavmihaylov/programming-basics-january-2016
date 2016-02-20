using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row <= n; row++)
        {
            // Left part
            Console.Write(new string(' ', n - row));
            Console.Write(new string('*', row));
            
            // middle
            Console.Write(" | ");

            // Right part
            Console.Write(new string('*', row));
            Console.Write(new string(' ', n - row));
            Console.WriteLine();
        }

    }
}