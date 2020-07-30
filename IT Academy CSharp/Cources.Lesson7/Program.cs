using System;

namespace Cources.Lesson7
{
  class Program
  {
    static void Main(string[] args)
    {
      Student student1 = new Student("Андрейка", "Тимохович");
      Student student2 = new Student("Виталька", "Тимохович");
      Student student3 = new Student("Валли", "Тимохович");
      Student student4 = new Student("Козел", "Тимохович");

      student1.PrintStudentName();
      student2.PrintStudentName();
      student3.PrintStudentName();
      student4.PrintStudentName();
















      Console.ReadLine();
    }
  }
}
