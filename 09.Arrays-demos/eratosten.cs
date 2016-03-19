using System;

class Arrays
{
    static bool[] primes;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        primes = new bool[n + 1];
        primes[0] = true;
        primes[1] = true;

        for (int cnt = 2; cnt <= n; cnt++)
        {
            if (IsPrime(cnt))
            {
                Console.WriteLine(cnt);
            }    
        }
    }

    static bool IsPrime(int number)
    {
        if (primes[number] == false)
        {
            for (int cnt = number; cnt < primes.Length; cnt += number)
            {
                primes[cnt] = true;
            }

            return true;
        }

        return false;
    }
}