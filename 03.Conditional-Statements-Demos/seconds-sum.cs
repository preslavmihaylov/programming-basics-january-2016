using System;

class SecondsSum
{
	static void Main()
	{
		int first = int.Parse(Console.ReadLine());
		int second = int.Parse(Console.ReadLine());
		int third = int.Parse(Console.ReadLine());
		
		int totalSeconds = first + second + third;
		
		int minutes = totalSeconds / 60;
		int spareSeconds = totalSeconds % 60;
		string secondsFormat = "";
		
		if (spareSeconds < 10)
		{
			secondsFormat += "0";
		}
		
		secondsFormat += spareSeconds;
		
		Console.WriteLine("{0}:{1}", minutes, secondsFormat);
		
	}
}