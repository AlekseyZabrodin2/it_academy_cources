using System;
using System.Diagnostics.CodeAnalysis;

namespace Cources.Lesson13
{
  public class Student { }
  public class Group { }
  class Program
  {
    static void Main(string[] args)
    {
      // divide by zero
      try
      {
        var a = 0;
        var result = 2 / a;
      }
      catch (DivideByZeroException exc)
      {
        Console.WriteLine("Возникло исключение " + exc.Message);
      }

      // index out of renge
      try
      {
        string[] arrey = new string[] { "что нибудь" };
        var item = arrey[2];
      }
      catch (IndexOutOfRangeException exc)
      {
        Console.WriteLine("Возникло исключение " + exc.Message);
      }

      // invalid cast 
      try
      {
        object student = new Student();
        Group group = (Group)student;
      }
      catch (InvalidCastException exc)
      {
        Console.WriteLine("Возникло исключение " + exc.Message);
      }

      // null reference
      try
      {
        Student student1 = null;
        student1.ToString();
      }
      catch (NullReferenceException exc)
      {
        Console.WriteLine("Возникло исключение " + exc.Message);
      }



      try
      {
        var a = Convert.ToInt32(Console.ReadLine());
        var result = 2 / a;
        string[] arrey = new string[] { "что нибудь" };
        var item = arrey[Convert.ToInt32(Console.ReadLine())];
      }
      catch (DivideByZeroException exc)
      {
        Console.WriteLine("Возникло исключение " + exc.Message);
      }
      
      catch (IndexOutOfRangeException exc)
      {
        Console.WriteLine("Возникло исключение " + exc.Message);
      }

      Console.ReadLine();

    }
  }
}
