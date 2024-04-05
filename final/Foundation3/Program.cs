using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple St", "Provo", "Utah", "02574");
        Address address2 = new Address("456 cottonwood St", "Paris", "Texas", "45344");
        Address address3 = new Address("789 Redwood Ct.", "Zesty", "Alaska", "31564");
    
        Event lecture = new Lecture("Run Forest, Run!", "This will be the best lecture you will ever attend. It will go into all the details of Forest Gump.", DateTime.Now.AddDays(21), "10:00 AM", address1, "Tom Hanks");
        Event reception = new Reception("Another Wedding Reception...", "We don't care if you come to our reception or not. We just want your gift money.", DateTime.Now.AddDays(14), "7:00 PM", address2, "dolladollabills@gmail.com");
        Event outdoorGathering = new OutdoorGathering("Musty Smell", "Would you like to sweat in the heat outdoors? join us this so we can all stink together! BYOD... (Bring your own deodorant)", DateTime.Now, "3:00 PM", address3);

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
