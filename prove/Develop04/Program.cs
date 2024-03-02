using System;

class Program
{
    static void Main()
    {
        int duration = 0;
        while (true)
        {
            Console.WriteLine("\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int activityChoice))
            {
                switch (activityChoice)
                {
                    case 1:
                        Console.Write("Enter duration for Breathing Activity (in seconds): ");
                        duration = int.Parse(Console.ReadLine());
                        Breathing breathing = new Breathing(duration);
                        breathing.Run();
                        break;
                    case 2:
                        Console.Write("Enter duration for Reflection Activity (in seconds): ");
                        duration = int.Parse(Console.ReadLine());
                        Reflection reflection = new Reflection(duration);
                        reflection.Run();
                        break;
                    case 3:
                        Console.Write("Enter duration for Listing Activity (in seconds): ");
                        duration = int.Parse(Console.ReadLine());
                        Listing listing = new Listing(duration);
                        listing.Run();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }
        }
    }
    
}