using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
		int sqrtNum = (int)Math.Sqrt(n);
		bool isPrime = true;
		
        for (int cnt = 2; cnt <= sqrtNum; ++cnt) 
		{
			if (n % cnt == 0) 
			{
				isPrime = false;
				break;
			}
		}
		
		if (isPrime && n >= 2) 
		{
			Console.WriteLine("Prime");
		}
		else
		{
			Console.WriteLine("Not prime");
		}
    }
}