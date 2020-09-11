using System;
using System.Diagnostics;

namespace Final_Test_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            string str = Console.ReadLine();
            int reverse = 0;
            try
            {
                Debug.Assert(str != null, "str != null");
                int ch = int.Parse(str);

                while (ch != 0)
                {
                    reverse = reverse * 10 + ch % 10;
                    ch /= 10;
                }
                Console.WriteLine(reverse);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadLine();
        }
    }
}
