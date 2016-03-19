using System;
using System.Linq;

class Arrays
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] {' '}
            , StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();


        for (int cnt = 0; cnt < 100; cnt++)
        {
            Console.WriteLine(numbers[cnt % numbers.Length]);
        }
    }
}