using System;

class LiveDemo
{
    static void Main()
    {
        int n;
        do
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break;
                }

                Console.WriteLine("The number is not even");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number.");
            }
        } while (true);
        Console.WriteLine("Even number entered: {0}", n);
    }
}