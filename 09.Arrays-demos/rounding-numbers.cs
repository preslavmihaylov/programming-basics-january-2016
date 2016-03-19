using System;
using System.Linq;

class Arrays
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(new char[] {' '}
            , StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).ToArray();

        for (int cnt = 0; cnt < numbers.Length; cnt++)
        {
            Console.WriteLine(
                numbers[cnt] + " => " + 
                Math.Round(numbers[cnt], MidpointRounding.AwayFromZero));
        }
    }
}