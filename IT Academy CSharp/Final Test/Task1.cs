using System;

class Task1
{
    public static int Main()
    {
        int start = 1;
        int end = 100;

        for (int i = 1; i <= end; i += start)
        {
            Console.Write("{0} ", i);
            start = i - start;
        }
        Console.ReadKey();
        return 0;
    }
}