using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Text;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        private const string N = "N";
        private const string Y = "Y";
        static void Main(string[]  args)
        {
            Console.CursorVisible = false;
            //ввод 
            var restart = true;
            while (restart)
            {
            int[,] maze = new int[,]
            {
                {1,1,1,1,8,1,1,1,1,1,1},
                {1,1,1,1,0,1,1,1,1,1,1},
                {1,0,1,1,0,1,0,0,0,1,1},
                {1,0,0,0,0,1,0,1,0,0,8},
                {1,1,1,1,0,1,0,1,0,1,1},
                {8,0,0,0,0,1,0,1,0,1,1},
                {1,1,0,1,1,1,0,1,0,1,1},
                {1,1,0,0,0,0,0,1,0,1,1},
                {1,1,1,1,1,1,1,1,0,1,1},
                {1,0,0,0,0,0,0,0,0,1,1},
                {1,1,1,1,1,1,0,1,1,1,1},
                {1,1,1,1,1,1,8,1,1,1,1}
            };
            
            string ansverYes ="Y";
            string ansverNo = "N";
            ansverNo = N;
            ansverYes = Y;
            //координаты игрока
            int x = 1, y = 1;
                while (true)
                {
                    //рисуем лабиринт
                    Console.Clear();
                    for (int i = 0; i < maze.GetLength(0); i++)
                    {
                        for (int j = 0; j < maze.GetLength(1); j++)
                        {
                            if (maze[i, j] == 0) Console.Write(".");
                            if (maze[i, j] == 1) Console.Write("#");
                            if (maze[i, j] == 8) Console.Write("П");
                            if (maze[i, j] == 9) Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("@");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;

                    // обработка ввода
                    ConsoleKeyInfo ki = Console.ReadKey(true);
                    if (ki.Key == ConsoleKey.Escape) break;

                    if (ki.Key == ConsoleKey.LeftArrow && (maze[y, x - 1] == 0 || maze[y, x - 1] == 8))
                    {
                        maze[y, x] = 9;
                        x--;
                    }

                    if (ki.Key == ConsoleKey.RightArrow && (maze[y, x + 1] == 0 || maze[y, x + 1] == 8))
                    {
                        maze[y, x] = 9;
                        x++;
                    }

                    if (ki.Key == ConsoleKey.UpArrow && (maze[y - 1, x] == 0 || maze[y - 1, x] == 8))
                    {
                        maze[y, x] = 9;
                        y--;
                    }

                    if (ki.Key == ConsoleKey.DownArrow && (maze[y + 1, x] == 0 || maze[y + 1, x] == 8))
                    {
                        maze[y, x] = 9;
                        y++;
                    }

                    // завершение игры
                    if (maze[y, x] == 8)

                    {

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.WriteLine("YOU WON");
                        Console.ReadLine();

                        Console.Clear();
                                               
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.WriteLine("TRY AGAIN ?");
                        Console.ReadLine();

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);                        
                        Console.WriteLine(" ENTER 'Y' OR 'N' ");
                        Console.ReadLine();

                        Console.Clear();

                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        
                        var answer = Console.ReadLine();
                        if (ansverNo == answer)
                        {
                            restart = false;
                            break;
                        }

                        if (ansverYes == answer)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            x = 1;
                            y = 1;

                            for (int i = 0; i < maze.GetLength(0); i++)
                            {
                                for (int j = 0; j < maze.GetLength(1); j++)
                                {
                                    if (maze[i, j] == 9)
                                    {
                                        maze[i, j] = 0;
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                    }




                    // Вариант ниже, выполняет тоже самое, только расписан каждый [if] 


                    //if (maze[y - 1, x] == 3)
                    //{
                    //    Console.WriteLine("Game OVER");
                    //    Console.ReadKey();
                    //    break;
                    //}

                    //if (maze[y + 1, x] == 3)
                    //{
                    //    Console.WriteLine("Game OVER");
                    //    Console.ReadKey();
                    //    break;
                    //}

                    //if (maze[y, x - 1] == 3)
                    //{
                    //    Console.WriteLine("Game OVER");
                    //    Console.ReadKey();
                    //    break;
                    //}

                    //if (maze[y, x + 1] == 3)
                    //{
                    //    Console.WriteLine("Game OVER");
                    //    Console.ReadKey();
                    //    break;
                    //}                  
                }
            }
        }
    }
}