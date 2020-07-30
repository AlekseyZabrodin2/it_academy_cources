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
      Console.WriteLine("Вариант 1 - Stack");
      Console.WriteLine();
      Console.ReadLine();

      Stack<Students> people = new Stack<Students>();
      people.Push(new Students() { Name = "Том" });
      people.Push(new Students() { Name = "Билл" });
      people.Push(new Students() { Name = "Вася" });
      people.Push(new Students() { Name = "Катя" });
      people.Push(new Students() { Name = "Толя" });
      people.Push(new Students() { Name = "Артурио" });
      people.Push(new Students() { Name = "Людмила" });

      //people.RemoveAt(4);
      //people.Reverse();
      //people.Clear();
      foreach (var item in people)
      {
        Console.WriteLine(item.Name);
      }
      Console.ReadLine();

      Console.WriteLine("\nПервый в очереди за кофе студент: {0}", people.Pop().Name);
      Console.WriteLine("Следующий в очереди студент: {0}", people.Peek().Name);
      Console.WriteLine("Первый в очереди студент: {0}", people.Pop().Name);

      Console.ReadLine();

      Console.WriteLine("Вариант 2 - MyQueue)");
      Console.WriteLine();

      Queue<Students> students = new Queue<Students>();

      students.Enqueue(new Students() { Name = "Djohn" });
      students.Enqueue(new Students() { Name = "Vity" });
      students.Enqueue(new Students() { Name = "Ivan" });
      students.Enqueue(new Students() { Name = "Valera" });
      students.Enqueue(new Students() { Name = "Sasha" });
      students.Enqueue(new Students() { Name = "Sergey" });
      students.Enqueue(new Students() { Name = "Dusiy" });

      foreach (var item in students)
      {
        Console.WriteLine($"А кофе у нас получает - {item.Name}");
        //Console.ReadLine();
      }

      Console.WriteLine("\nПервый в очереди за кофе студент: {0}", students.Dequeue().Name);
      Console.WriteLine("Следующий в очереди студент: {0}", students.Peek().Name);
      Console.WriteLine("Первый в очереди студент: {0}", students.Dequeue().Name);

      Console.ReadLine();
    }
  }
}