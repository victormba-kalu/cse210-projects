using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //job1.Display();


        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //

        Resume myResume = new Resume();
        myResume._name = "Victor Mba";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }

}     
  