using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Paint inspector";
        job1._company = "Coating Systems and Supply";
        job1._startYear = 2018;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Lead Install Technician";
        job2._company = "Vivint";
        job2._startYear = 2019;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jay Brown";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}