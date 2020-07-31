using System;
using System.Threading;

namespace IT_Academy_CSharp
{
  public class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    private int age;
    public int Age
    {
      get
      {
        return age;
      }
      set
      {
        if (value >= 18)
        {
          age = value;
        }
        else
        {
          throw new ArgumentException("Возраст студента должен быть не меньше 18 лет");
        }
      }
    }
    public Group Group { get; set; }

    public Student(string firstName, string lastName, DateTime birthDate)
    {
      FirstName = firstName;
      LastName = lastName;
      BirthDate = birthDate;
    }
    public Student(string firstName, string lastName, DateTime birthDate, Group group) : this(firstName, lastName, birthDate)
    {
      Group = group;
    }

    public override string ToString()
    {
      return $"студент {this.LastName}, {this.FirstName[0]}. Из группы {Group.Number}.";
    }




  }
}