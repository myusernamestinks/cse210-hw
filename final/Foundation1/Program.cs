using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] randomTitles = {
            "Adventures in Wonderland",
            "The Secret Life of Pets",
            "Epic Fail Compilation",
            "Cooking Masterclass: Italian Cuisine",
            "Unboxing the Latest Gadgets",
            "Exploring Ancient Ruins",
            "The Art of Photography: Mastering Composition",
            "DIY Home Improvement Projects",
            "Thrilling Roller Coaster Rides",
            "Funny Moments with Friends"
        };

        var videos = new List<Video>();

        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            string title = randomTitles[rand.Next(randomTitles.Length)];
            string[] randomAuthors = {
                "Giggles McGee",
                "Phil A. Buster",
                "Al Beback",
                "Sir Reginald Puddingbottom III",
                "Anita Bath",
                "Jessica Jones",
                "Toots McTooterson",
                "Polly Esther",
                "Justin Thyme",
                "Robin Banks"
            };
            string author = randomAuthors[rand.Next(randomAuthors.Length)];
            int length = rand.Next(60, 346); 
            Video video = new Video(title, author, length);
            videos.Add(video);
        }

        
        string[] randomComments = { 
            "Great video!", 
            "Very informative", 
            "Love it!", 
            "Awesome content", 
            "Interesting", 
            "I learned a lot from this", 
            "Keep up the good work, Love Mom",
            "This is so boring!",
            "HAHAHAHAHA",
            "I can't believe what I just watched. lol",
            "BORING!", 
            "this is grandma, how do I work this box",
            "Great job!",
            "We need more!",
            "I forgot my popcorn for this!",
            "**YAWN**",            
            };
            
        foreach (var video in videos)
        {
            for (int i = 0; i < 3; i++)
            {
                string commenterName = $"Commenter {rand.Next(1, 101)}"; 
                string commentText = randomComments[rand.Next(randomComments.Length)]; 
                video.AddComment(commenterName, commentText);
            }
        }

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}