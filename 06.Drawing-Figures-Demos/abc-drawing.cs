using System;

class LiveDemo
{
    static void Main()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 50; col++)
            {
                int remainder = col % 3;
                if (remainder == 0)
                {
                    Console.Write('a');
                }
                else if (remainder == 1)
                {
                    Console.Write('b');
                }
                else if (remainder == 2)
                {
                    Console.Write('c');
                }
            }

            Console.WriteLine();
        }
    }
}