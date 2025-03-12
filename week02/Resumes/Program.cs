using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Job
        Job job1 = new Job();
        job1._company = "Intermedia";
        job1._jobTitle = "QA Engineer";
        job1._startYear = 2022;
        job1._endYear = 2026;

        // Create another instance of Job
        Job job2 = new Job();
        job2._company = "Light-it";
        job2._jobTitle = "QA Specialist";
        job2._startYear = 2026;
        job2._endYear = 2029;

        // Create an instance of Resume
        Resume resume1 = new Resume();
        resume1._name = "Fernanda Souza";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.DisplayResumeDetails();
    }
}