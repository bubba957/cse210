using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Culvers";
        job1._jobTitle = "Cashier";
        job1._startYear = 2013;
        job1._endYear = 2015;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Postnet";
        job2._jobTitle = "Graphic Designer";
        job2._startYear = 2015;
        job2._endYear = 2020;
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Cody Smith";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}