using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IT_Academy_CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Group group = new Group("G12");
      Student student = new Student("Алексей", "Забродин", new DateTime(1980, 12, 25), group);
      Student student1 = new Student("Вася", "Петров", new DateTime(1984, 12, 25), group);
      student.Age = 18;
      student1.Age = 20;

      Console.WriteLine(student);
      Console.WriteLine($"студент {student1.LastName}, {student1.FirstName[0]}.");
      Console.ReadLine();
    }
  }
}