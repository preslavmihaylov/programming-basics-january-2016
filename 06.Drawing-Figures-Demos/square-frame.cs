using System;

class LiveDemo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            string result = "";
            for (int col = 0; col < n; col++)
            {
                if ((col == 0 || col == n - 1) && (row != 0 && row != n - 1))
                {
                    result += "| ";
                }
                else if (col == 0 || col == n - 1)
                {
                    result += "+ ";
                }
                else
                {
                    result += "- ";
                }
            }
            result = result.Trim();

            //result = result.Substring(0, result.Length - 1);
            Console.WriteLine(result);
        }
    }
}