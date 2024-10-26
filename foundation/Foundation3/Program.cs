using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity(0);
        // List<Activity> activities = new List<Activity>();

        Running running = new Running(30, 3.0, 6.0, 10.0);
        Console.WriteLine(running.GetRunning());

        Console.WriteLine();
        Bicycles bicycle = new Bicycles(10, 9.7);
        Console.WriteLine(bicycle.GetBicycling());

        Console.WriteLine();
        Swimming swimming = new Swimming(15, 4);
        Console.WriteLine(swimming.GetSwimming());

        // void GetSummary(Activity activities)
        // {
        //     // DateTime fullDate = DateTime.Now;
        //     // string date = fullDate.ToString("dd MMM yyyy");
        //     // // string activity = 
        //     // double distance = activities.GetDistance();
        //     // double speed = activities.GetSpeed();
        //     // double pace = activities.GetPace();

        //     // Console.WriteLine($"{date}{distance}{speed}{pace}");
        //     // Console.WriteLine();
        // }
    }
}