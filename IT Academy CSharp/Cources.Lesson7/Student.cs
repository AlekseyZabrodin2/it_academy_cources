using System;
using System.Collections.Generic;
using System.Text;

namespace Cources.Lesson7
{
  class Student
  {
    public string FirstName { get; set; }
    public double AverageMarc { get; set; }
    public string SecendName { get; set; }

    int[] mark = new int[4];
    Random random = new Random();

    public Student(string fName, string sName)
    {
      FirstName = fName;
      SecendName = sName;
      
      for (int i = 0; i < mark.Length; i++)
      {
        mark[i] = random.Next(0, 11);
        AverageMarc += mark[i];
      }
      AverageMarc = AverageMarc / mark.Length;
    }

    public void PrintStudentName()
    {
      Console.WriteLine($"student {FirstName} {SecendName}");
    }


  }
}
