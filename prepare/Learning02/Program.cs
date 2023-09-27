using System;

class Program
{
    static void Main(string[] args)
    {
        //Create, fill, and display job1
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2023;
        // job1.Display();

        //Create and fill job2
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Manager";
        job2._startYear = 2017;
        job2._endYear = 2019;

        //Create, fill, and display resume1
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // resume1._jobs[0].Display();
        resume1.Display();
    }
}