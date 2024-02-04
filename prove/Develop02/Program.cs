using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
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

        //Generates a prompt randomly from the list of prompts below and presents it to the user - adds timestamp
        static void WriteEntry()
        {
            string prompt = PromptList();
            Console.WriteLine("Prompt: " + prompt);
            Console.Write("Please type your response: ");
            string response = Console.ReadLine();
            Entry newEntry = new Entry(prompt, response, DateTime.Now);
            journal.Add(newEntry);
        }

        static string PromptList()
        {
            List<string> prompts = new List<string>
        {
            "What inspired me today?",
            "What was the best part of my day?",
            "What did I do today to show my wife I love her?",
            "How did I serve the Lord today?",
            "If I had one thing I could do over today, what would it be?"
        };
            Random rand = new Random();
            return prompts[rand.Next(prompts.Count)];
        }

        static void DisplayJournal()
        {
            if (journal.Count == 0)
            {
                Console.WriteLine("Journal is empty."); //displays message if no entrys have been entered.
                return;
            }

            foreach (var entry in journal)
            {
                Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}"); //Displays what has been enter with timestamp if there are available entries.
            }
        }

        static void SaveJournalFile()
        {
            Console.Write("Enter filename to save: "); //ask you to save the file under a name
            string filename = Console.ReadLine();


            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in journal)
                {
                    outputFile.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved to file.");
        }

        static void LoadJournalFile()
        {
            Console.Write("Enter filename to load: "); //pull of the saved file and prints the info.
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Journal loaded from file.");
        }
    }
}

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }
    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}

