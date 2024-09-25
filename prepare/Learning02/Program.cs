using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Microsft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2016;
        job1._endYear = 2018;

        job2._company = "Bing";
        job2._jobTitle = "IT";
        job2._startYear = 2018;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume resume = new Resume();

        resume._name = "Cody Smith";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}