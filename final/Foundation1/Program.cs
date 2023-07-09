using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How Sharks Grow Legs", "Doc Martin", 120);
        video1.AddComment(new Comment("Frank2039", "I knew one of these was following me home yesterday"));
        video1.AddComment(new Comment("Dale Rizzheart Jr.", "Top quality, pretty sure I picked one up in a bar once."));
        video1.AddComment(new Comment("Not-A-Shark","Totally bogus. No way any of this is true..."));
        videos.Add(video1);

        Video video2 = new Video("What I Saw In The Wall As The Paint Dried", "Dr. Ed Scott", 120);
        video2.AddComment(new Comment("Mr. TinLkJR", "What no Baroque era murals? I call lies."));
        video2.AddComment(new Comment("Cinderblok.", "I'm very distracted by the fireworks. How did they get in there?"));
        videos.Add(video2);

        Video video3 = new Video("Sleep Deprivation Makes Cleaning Fun!", "NoSleepAreWe", 120);
        video3.AddComment(new Comment("Lu'Seal Ball", "I don't know what to say to this. I must also be tired enough to clean."));
        video3.AddComment(new Comment("Bruce Willendthis","I work as a professioanl cleaner, needless to say, I never sleep."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: "+ video.title);
            Console.WriteLine("Author: "+ video.author);
            Console.WriteLine("Length " + video.lengthInSeconds + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine(" - " + comment.commenterName + ": " + comment.commentText);
            }
            Console.WriteLine();
        }
    }
}