using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int cnt = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int offset = row + col + 1;
                if (offset > n)
                {
                    offset = 2 * n - offset;
                }
                Console.Write(offset + " ");
            }
            Console.WriteLine();
        }
    }
}