using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cources.Lesson7
{
  class Student
  {
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int[] Mark { get; set; }
    public double SumMark { get; set; }
    public double MiddleMark { get; set; }

    Random random = new Random();
    public Student(string firstName, string secondName)
    {
      MiddleMark = 0f;
      FirstName = firstName;
      SecondName = secondName;
      Mark = new int[5];
      SumMark = 0;

      for (int mk = 0; mk < Mark.Length; mk++)
      {
        Mark[mk] = random.Next(1, 10);
        SumMark = SumMark + Mark[mk];
      }

      MiddleMark = SumMark / Mark.Length;
      //Console.WriteLine($"{SumMark}");
      //Console.WriteLine($"{MiddleMark}");
    }
    public override string ToString()
    {
      return $"Студент {FirstName} {SecondName} получает {MiddleMark}.";
    }    
    public void PrintAllMark()
    {
      Console.WriteLine($"Студент {FirstName} {SecondName} получил следующие оценки: ");

      foreach (var item in Mark)
      {
        Console.Write(item );        
      }
      Console.WriteLine();
    }






  }
}
