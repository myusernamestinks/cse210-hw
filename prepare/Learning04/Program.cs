using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment a1 = new Assingment("Dwayne Johnson", "Division");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Toby Keith", "Decimals", "12.4", "29-1003");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jack Black", "Mexican Wrestling", "Nacho Libre");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}