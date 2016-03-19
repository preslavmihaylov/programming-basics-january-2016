using System;
using System.Threading;

class RandomFruits
{
    struct Point
    {
        public int X;
        public int Y;
    }

    struct Fruit
    {
        public Point Position;
    }

    static int WindowHeight = 20;
    static int WindowWidth = 30;

    // This is the star object to be used.
    static Fruit fruit = new Fruit();

    static Random randGenerator = new Random();

    static void PrintOnPosition(int row, int col, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(col, row);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void InitSettings()
    {
        Console.WindowHeight = WindowHeight;
        Console.WindowWidth = WindowWidth;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        Console.CursorVisible = false;
        Console.Clear();
    }

    static void Main()
    {
        InitSettings();
        uint gameCnt = 0;

        while (true)
        {
            // TODO: Check if the gameCnt has reached a certain value
            if (false)
            {
                DeleteFruit();
                GenerateNewFruit();
                DrawFruit();
            }

            Thread.Sleep(100);
            gameCnt++;
        }
    }

    static void GenerateNewFruit()
    {
        // TODO: Generate random values for x and y
        
        // TODO: set the generated values to the fruit coordinates
    }

    static void DrawFruit()
    {
        // TODO: Draw the character of the fruit at the current position
    }


    static void DeleteFruit()
    {
        // TODO: Delete the character at the last fruit coordinates
    }
}