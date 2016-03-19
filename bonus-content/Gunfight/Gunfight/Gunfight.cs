using System;
using System.Collections.Generic;
using System.Threading;

class Gunfight
{
    class Point
    {
        public int row;
        public int col;
    }

    const int WindowWidth = 50;
    const int WindowHeight = 10;
    const int ScreenUpperBorder = 2;
    const int ScreenLowerBorder = WindowHeight - 2;
    const int EnemyStartOffset = WindowWidth;
    static bool IsGameOver = false;
    const int CollisionAOE = 1;
    static Random randGenerator = new Random();

    /* Player info */
    static int playerRow = 0;
    static int playerCol = 0;
    static string playerFigure = "[0]";
    static ConsoleColor playerColor = ConsoleColor.Red;

    /* Enemy info */
    static List<Point> enemies = new List<Point>();
    static string enemyFigure = "%";
    static ConsoleColor enemyColor = ConsoleColor.DarkMagenta;
    static int EnemySpawnChance = 10;

    /* Bullet info */
    static List<Point> bullets = new List<Point>();
    static string bulletFigure = "-";
    static ConsoleColor bulletColor = ConsoleColor.Black;

    static void Main(string[] args)
    {
        InitialiseSettings();

        while (!IsGameOver)
        {
            Clear();
            CheckCollisions();
            Update();
            Draw();

            Thread.Sleep(100);
        }
    }

    #region Utility Methods
    static void PrintOnPosition(int row, int col, string text, ConsoleColor color)
    {
        Console.SetCursorPosition(col, row);
        Console.ForegroundColor = color;
        Console.Write(text);
    }

    static void InitialiseSettings()
    {
        Console.WindowWidth = WindowWidth;
        Console.WindowHeight = WindowHeight;
        Console.BufferWidth = WindowWidth;
        Console.BufferHeight = WindowHeight;

        Console.CursorVisible = false;
    }

    static bool IsObjectInBounds(int row, int col)
    {
        return row >= ScreenUpperBorder &&
               row <= WindowHeight - 1 &&
               col >= 0 &&
               col <= WindowWidth - 1;
    }
    
    static bool DoObjectsCollide(int firstRow, int firstCol, int secondRow, int secondCol)
    {
        int colOffset = Math.Abs(firstCol - secondCol);

        return firstRow == secondRow &&
            colOffset <= CollisionAOE;
    }

    #endregion

    #region Player Methods
    static void ClearPlayer()
    {
        PrintOnPosition(playerRow, playerCol, "   ", playerColor);
    }

    static void DrawPlayer()
    {
        PrintOnPosition(playerRow, playerCol, playerFigure, playerColor);
    }

    static void UpdatePlayer()
    {
        ReadInput();
    }

    static void ReadInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            if (userInput.Key == ConsoleKey.LeftArrow && playerCol > 0)
            {
                playerCol--;
            } 
            else if (userInput.Key == ConsoleKey.RightArrow && playerCol < WindowWidth - 3)
            {
                playerCol++;
            }
            else if (userInput.Key == ConsoleKey.DownArrow && playerRow < ScreenLowerBorder)
            {
                playerRow++;
            }
            else if (userInput.Key == ConsoleKey.UpArrow && playerRow > ScreenUpperBorder)
            {
                playerRow--;
            }
            else if (userInput.Key == ConsoleKey.Spacebar)
            {
                bullets.Add(new Point()
                {
                    row = playerRow,
                    col = playerCol + 2
                });
            }
        }
    }
    #endregion

    #region Enemy Methods
    static void ClearEnemies()
    {
        for (int cnt = 0; cnt < enemies.Count; cnt++)
        {
            if (IsObjectInBounds(enemies[cnt].row, enemies[cnt].col))
            {
                PrintOnPosition(enemies[cnt].row, enemies[cnt].col, " ", enemyColor);
            }
        }
    }

    static void DrawEnemies()
    {
        for (int cnt = 0; cnt < enemies.Count; cnt++)
        {
            if (IsObjectInBounds(enemies[cnt].row, enemies[cnt].col))
            {
                PrintOnPosition(enemies[cnt].row, enemies[cnt].col, enemyFigure, enemyColor);
            }
        }
    }

    static void UpdateEnemies()
    {
        SpawnEnemy();

        for (int cnt = 0; cnt < enemies.Count; cnt++)
        {
            enemies[cnt].col--;
            if (enemies[cnt].col < 0)
            {
                enemies.RemoveAt(cnt);
                cnt--;
            }
        }
    }

    static void SpawnEnemy()
    {
        int chance = randGenerator.Next(100);
        if (chance < EnemySpawnChance)
        {
            int row = randGenerator.Next(ScreenUpperBorder, ScreenLowerBorder);
            int col = randGenerator.Next(0, WindowWidth) + EnemyStartOffset + 20;


            enemies.Add(new Point()
                {
                    row = row,
                    col = col
                });
        }
    }
    #endregion

    #region Bullet Methods
    static void ClearBullets()
    {
        for (int cnt = 0; cnt < bullets.Count; cnt++)
        {
            if (IsObjectInBounds(bullets[cnt].row, bullets[cnt].col))
            {
                PrintOnPosition(bullets[cnt].row, bullets[cnt].col, " ", bulletColor);
            }
        }
    }

    static void DrawBullets()
    {
        for (int cnt = 0; cnt < bullets.Count; cnt++)
        {
            if (IsObjectInBounds(bullets[cnt].row, bullets[cnt].col))
            {
                PrintOnPosition(bullets[cnt].row, bullets[cnt].col, bulletFigure, bulletColor);
            }
        }
    }
    
    static void UpdateBullets()
    {
        for (int cnt = 0; cnt < bullets.Count; cnt++)
        {
            bullets[cnt].col++;
            if (bullets[cnt].col > WindowWidth - 1)
            {
                bullets.RemoveAt(cnt);
                cnt--;
            }
        }
    }
    #endregion

    #region Collision Methods
    static void CheckEnemyBulletsCollision()
    {
        for (int bulletIndex = 0; bulletIndex < bullets.Count; bulletIndex++)
        {
            for (int enemyIndex = 0; enemyIndex < enemies.Count; enemyIndex++)
            {
                if (DoObjectsCollide(
                    bullets[bulletIndex].row, 
                    bullets[bulletIndex].col, 
                    enemies[enemyIndex].row,
                    enemies[enemyIndex].col))
                {
                    bullets.RemoveAt(bulletIndex);
                    enemies.RemoveAt(enemyIndex);
                    bulletIndex--;
                    enemyIndex--;
                    break;
                }
            }
        }
    }

    static void CheckEnemyPlayerCollision()
    {
        for (int enemyIndex = 0; enemyIndex < enemies.Count; enemyIndex++)
        {
            if (DoObjectsCollide(
                enemies[enemyIndex].row,
                enemies[enemyIndex].col,
                playerRow,
                playerCol + 2))
            {
                IsGameOver = true;
            }
        }
    }

    static void CheckCollisions()
    {
        CheckEnemyBulletsCollision();
        CheckEnemyPlayerCollision();
    }
    #endregion

    #region Main Game Methods
    static void Clear()
    {
        ClearPlayer();
        ClearEnemies();
        ClearBullets();
    }

    static void Draw()
    {
        DrawPlayer();
        DrawEnemies();
        DrawBullets();
    }

    static void Update()
    {
        UpdatePlayer();
        UpdateEnemies();
        UpdateBullets();
    }
    #endregion
}