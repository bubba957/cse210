// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");
//         Console.WriteLine("This is in C#");
//     }
// }
using System;


  class Job
  {
    string color = "red";

    static void Main(string[] args)
    {
      Job myObj = new Job();
      Console.WriteLine(myObj.color);
    }
  }

  using System;
  public class Job
  {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    static void Main(string[] args)
    {
      Job job1 = new Job();
      job1._company = "Culvers";
      job1._jobTitle = "Cashier";
      job1._startYear = 2013;
      job1._endYear = 2015;
      job1.Display();
    }
  }