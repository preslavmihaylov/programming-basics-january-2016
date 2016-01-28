using System;
using System.Threading;

class ControlledStar
{
    struct Point
    {
        public int X;
        public int Y;
    }

    struct Star
    {
        public Point Position;
    }

    static int WindowHeight = 20;
    static int WindowWidth = 30;

    // This is the star object to be used.
    static Star star = new Star();

    // These fields represent the rate of change of the star's x and y values
    static int xVelocity = 0;
    static int yVelocity = 0;

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

        // Adjust the star's starting position
        star.Position.X = WindowHeight - 1;
        star.Position.Y = 0;

        while (true)
        {
            ClearStar();
            ReadInput();
            UpdateStarData();
            DrawStar();
            Thread.Sleep(200);
        }
    }

    static void ReadInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo userInpu = Console.ReadKey();
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            // TODO: Check key value and update velocities correspondingly
        }
    }


    static void UpdateStarData()
    {
        // TODO: Change the star coordinates by the given velocities

        // TODO: Set the velocities to default values to avoid constant movement
    }

    static void ClearStar()
    {
        // TODO: Clear the char at the current star position
    }

    static void DrawStar()
    {
        // TODO: Draw a * character at the current star position
    }
}