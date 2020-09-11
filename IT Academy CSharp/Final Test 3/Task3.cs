using System;

namespace Final_Test_3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    arr[i] = rand.Next(1, 10);

                else
                    arr[i] = (rand.Next(1, 10)) * -1;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
           // int abs = Math.Abs(arr[i]);
            //Console.WriteLine(abs);         ДОРАБОТАТЬ и исправить !!!!!
            Console.ReadLine();
        }
    }
}
