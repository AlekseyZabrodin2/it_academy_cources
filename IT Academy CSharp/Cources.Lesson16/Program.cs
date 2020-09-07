using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson16
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[] numbers = new int[] { 12, 34, 2, 19, 10, 123, 54, 4 };
      int[] numbers = new int[] { 8, 2, 2, 4, 3, 6, 3 };

      //List<int> numbersUnic = new List<int>();

      //foreach(int number in numbers)
      //{
      //    if(!numbersUnic.Contains(number))
      //    {
      //        numbersUnic.Add(number);
      //    }

      //}
      var str = "А роза упала на лапу азора".Distinct();
      List<int> numbersUnic = numbers.Distinct().ToList();

      for (int i = 0; i < numbersUnic.Count; i++)
      {
        Console.Write(numbersUnic[i] + " - ");
        for (int j = 0; j < numbersUnic.Count; j++)
        {
          if (i == j)
          {
            continue;
          }
          if (numbersUnic[i] % numbersUnic[j] == 0)
          {

            Console.Write(numbersUnic[j] + " ");

          }

        }
        Console.WriteLine();

      }

      Console.ReadLine();
    }
  }
}