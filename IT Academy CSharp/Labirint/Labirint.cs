using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //ввод 
            int[,] maze = new int[,]
            {
                {1,1,1,1,3,1,1,1,1,1,1},
                {1,1,1,1,0,1,1,1,1,1,1},
                {1,0,1,1,0,1,0,0,0,1,1},
                {1,0,0,0,0,1,0,1,0,0,3},
                {1,1,1,1,0,1,0,1,0,1,1},
                {3,0,0,0,0,1,0,1,0,1,1},
                {1,1,0,1,1,1,0,1,0,1,1},
                {1,1,0,0,0,0,0,1,0,1,1},
                {1,1,1,1,1,1,1,1,0,1,1},
                {1,0,0,0,0,0,0,0,0,1,1},
                {1,1,1,1,1,1,0,1,1,1,1},
                {1,1,1,1,1,1,3,1,1,1,1}
            };

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
                        if (maze[i, j] == 3) Console.Write("П");
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

                if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 0)
                {                    
                    maze[y, x] = 9;
                    x--;
                }
                
                if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 0)
                {
                    maze[y, x] = 9;
                    x++;
                }
               
                if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 0)
                {
                    maze[y, x] = 9;
                    y--;
                }
                
                if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 0) 
                {
                    maze[y, x] = 9;
                    y++;
                }                
                
                // завершение игры
                if ((maze[y - 1, x] == 3) || (maze[y + 1, x] == 3) || (maze[y, x - 1] == 3) || (maze[y, x + 1] == 3))
                {
                   
                    Console.Clear();                    
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition( Console.WindowWidth/2, Console.WindowHeight / 2);
                    Console.WriteLine("YOU WON");

                    Console.ReadLine();
                    
                    Console.Clear();
                                        
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.WriteLine("GAME OVER");

                    Console.ReadKey();
                    break;
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