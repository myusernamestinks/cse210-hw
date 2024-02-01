using System;
class Program
{
    static List<Entry> journal = new List<Entry>();


class JournalEntry
{
    static void Main(string[] args)
    {
        bool running = true;

//The menu choices given to the user. 
        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

//Ask for users desired action
            Console.Write("Please, choose an option: ");
            string choice = Console.ReadLine();


//Takes the users response and produces the desired outcome
            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalFile();
                    break;
                case "4":
                    LoadJournalFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

}}