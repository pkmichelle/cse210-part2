using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer"; 
        job1._startYear = 2016;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager"; 
        job2._startYear = 2023;
        job2._endYear = 2025;

        job1.DisplayJobInfo();
        job2.DisplayJobInfo();

        Resume resume1 = new Resume();
        resume1._name = "Paige Koster";
        // instead of setting the variable to something, we add the already existing
        // class to the list we made in the Resume class, because _jobs is a list
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}