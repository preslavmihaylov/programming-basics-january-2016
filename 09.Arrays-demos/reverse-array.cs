using System;
using System.Linq;

class Arrays
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] {' '}
            , StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        for (int cnt = 0; cnt < numbers.Length / 2; cnt++)
        {
            int temp = numbers[numbers.Length - 1 - cnt];
            numbers[numbers.Length - 1 - cnt] = numbers[cnt];
            numbers[cnt] = temp;
        }

        Console.WriteLine(string.Join(" ", numbers);
    }
}