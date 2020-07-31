using System;

namespace Cources.Lesson7
{
  class Program
  {
    static void Main(string[] args)
    {
      Student student1 = new Student("Андрейка", "Карасев");
      Student student2 = new Student("Виталька", "Тимохович");
      Student student3 = new Student("Валли", "Пустельников");
      Student student4 = new Student("Константин", "Тибиулина");

      student1.PrintAllMark();
      student2.PrintAllMark();
      student3.PrintAllMark();
      student4.PrintAllMark();

      Console.WriteLine();

      Console.WriteLine(student1);
      Console.WriteLine(student2);
      Console.WriteLine(student3);
      Console.WriteLine(student4);

      Console.ReadLine();
    }
  }
}
