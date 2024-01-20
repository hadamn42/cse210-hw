using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Programmer";
        job1._startYear = 1999;
        job1._endYear = 2015;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Senior Programmer";
        job2._startYear = 2015;
        job2._endYear = 2024;
        // job2.Display();

        Resume Adam = new Resume();
        Adam._Name = "Adam Humes";
        Adam._Jobs.Add(job1);
        Adam._Jobs.Add(job2);

        Adam.DisplayResume();
    }
}