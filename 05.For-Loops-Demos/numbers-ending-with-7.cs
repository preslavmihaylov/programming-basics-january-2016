using System;

class LiveDemo
{
    static void Main()
    {
        for (int cnt = 0; cnt <= 1000; cnt++)
        {
            if (cnt % 10 == 7)
            {
                Console.WriteLine(cnt);
            }
        }
    }
}