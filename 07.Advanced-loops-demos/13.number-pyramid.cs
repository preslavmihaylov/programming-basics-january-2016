using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int cnt = 1;
        bool hasFinished = false;

        for (int row = 0; row < n && !hasFinished; row++)
        {
            for (int col = 0; col <= row && !hasFinished; col++)
            {
                Console.Write(cnt + " ");
                ++cnt;
                if (cnt > n)
                {
                    hasFinished = true;
                }
            }
            Console.WriteLine();
        }
    }
}