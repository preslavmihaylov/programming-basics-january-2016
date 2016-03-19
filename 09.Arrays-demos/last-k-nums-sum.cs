using System;

class Arrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];
        numbers[0] = 1;

        for (int cnt = 1; cnt < numbers.Length; cnt++)
        {
            numbers[cnt] = SumOfPreviousKElements(numbers, cnt, k);
        }

        for (int cnt = 0; cnt < numbers.Length; cnt++)
        {
            Console.Write(numbers[cnt] + " ");
        }
        Console.WriteLine();   
    }

    static long SumOfPreviousKElements(long[] numbers, int index, int k)
    {
        long sum = 0;

        for (int cnt = Math.Max(index - k, 0); cnt < index; cnt++)
        {
            sum += numbers[cnt];
        }

        return sum;
    }
}