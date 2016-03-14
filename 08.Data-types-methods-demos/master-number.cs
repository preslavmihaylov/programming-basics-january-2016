using System;

class LiveDemo
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int cnt = 1; cnt <= number; cnt++)
        {
            if (IsMasterNumber(cnt))
            {
                Console.WriteLine(cnt);
            }
        }
    }

    static bool IsMasterNumber(int number)
    {
        return IsPalindrome(number) && DigitsSumDivBy7(number) && HasEvenDigit(number);
    }

    static bool IsPalindrome(int number)
    {
        string numberAsString = Convert.ToString(number);
        for (int cnt = 0; cnt < numberAsString.Length / 2; cnt++)
        {
            if (numberAsString[cnt] != numberAsString[numberAsString.Length - 1 - cnt])
            {
                return false;
            }
        }

        return true;
    }

    static bool DigitsSumDivBy7(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum % 7 == 0;
    }

    static bool HasEvenDigit(int number)
    {
        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                return true;
            }

            number /= 10;
        }

        return false;
    }

    static int GetDigit(int number, int pos)
    {
        string num = Convert.ToString(number);
        return num[pos] - '0';
    }
}