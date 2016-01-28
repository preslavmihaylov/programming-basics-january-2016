using System;

class Game
{
    static int WindowHeight = 20;
    static int WindowWidth = 30;

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
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        if (row - 2 < 0 || row + 2 >= WindowHeight ||
            col + 3 >= WindowWidth || col < 0)
        {
            Console.WriteLine("Invalid input coords");
            return;
        }

        InitSettings();
        PrintOnPosition(row, col, "*", ConsoleColor.Red);
        PrintOnPosition(row - 1, col + 1, "*", ConsoleColor.Red);
        PrintOnPosition(row - 2, col + 2, "*", ConsoleColor.Red);

        PrintOnPosition(row - 1, col + 3, "*", ConsoleColor.Red);
        PrintOnPosition(row, col + 4, "*", ConsoleColor.Red);

        PrintOnPosition(row + 1, col + 3, "*", ConsoleColor.Red);
        PrintOnPosition(row + 2, col + 2, "*", ConsoleColor.Red);

        PrintOnPosition(row + 1, col + 1, "*", ConsoleColor.Red);

        Console.ReadLine();
    }
}