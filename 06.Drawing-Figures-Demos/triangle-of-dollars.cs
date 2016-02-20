using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                if (col == row)
                {
                    Console.Write("$");
                }
                else
                {
                    Console.Write("$ ");
                }
            }

            Console.WriteLine();
        }
    }
}