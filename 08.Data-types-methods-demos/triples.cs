using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int first = 'a'; first < n + 'a'; first++)
        {
            for (int second = 'a'; second < n + 'a'; second++)
            {
                for (int third = 'a'; third < n + 'a'; third++)
                {
                    Console.WriteLine("{0}{1}{2}", 
                        (char)(first), 
                        (char)(second), 
                        (char)(third));
                }
            }
        }
    }
}