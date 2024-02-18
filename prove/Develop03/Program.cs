using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = GetScriptures();
        Random random = new Random();

        foreach (Scripture scripture in scriptures)
        {
            while (!scripture.AllWordsHidden)
            {
                Console.WriteLine($"Scripture Reference: {scripture.Reference}");
                Console.WriteLine($"{scripture.Text}");
                Console.WriteLine();

                Console.WriteLine("Press Enter to hide more words or type 'quit' to end the program.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                scripture.HideWords(random);
                scripture.Display();
            }

            break;
        }
    }

    static List<Scripture> GetScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();


        scriptures.Add(new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture("Proverbs 3:5-6", "5,  Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6, In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."));
        scriptures.Add(new Scripture("John 7:17", "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself."));
        scriptures.Add(new Scripture("Leviticus 19:18", " Thou shalt not avenge, nor bear any grudge against the children of thy people, but thou shalt love thy neighbour as thyself: I am the Lord."));
        scriptures.Add(new Scripture("Alma 37:35", "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God."));
        scriptures.Add(new Scripture("Moroni 7: 45", "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things."));

        scriptures = scriptures.OrderBy(x => Guid.NewGuid()).ToList();

        return scriptures;
    }
}