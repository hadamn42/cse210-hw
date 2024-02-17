using System;

class Program
{
    static void Main(string[] args)
    {   List<Video> videos = new List<Video>();


        Video video1 = new Video("Cat and Cucumber", "FunnyCatVideos", 36);
        videos.Add(video1);

        Comment cnc1 = new Comment("Catfalfa", "Hilarious!");
        video1.AddComment(cnc1);
        Comment cnc2 = new Comment("DoggyGid", "LAMAO! Dumb Cat");
        video1.AddComment(cnc2);
        Comment cnc3 = new Comment("MyOtherCatisaCat", "Watched these videos for hours! How do I change my feed?");
        video1.AddComment(cnc3);
        Comment cnc4 = new Comment("Totally Human", "What a tasty c ucumber at... (edited)");
        video1.AddComment(cnc4);

        Video video2 = new Video("How Lizardmen Control the Supreme Court", "RealTrueNews", 9000);
        videos.Add(video2);

        Comment lizard1 = new Comment("Grandpappy1958", "Is this the Google?");
        video2.AddComment(lizard1);
        Comment lizard2 = new Comment("DoggyGid", "You've got it wrong! It's squirrels! Squirrels to the top!");
        video2.AddComment(lizard2);
        Comment lizard3 = new Comment("GrigoryIII", "I haven't watched this yet, but you should take it down. This is all lies!");
        video2.AddComment(lizard3);

        Video video3 = new Video("Makeup vlog 42342: Looking like a Lizarman to blend in", "Totally Human", 1500);
        videos.Add(video3);
        
        Comment makeup1 = new Comment("RealTrueNews", "Intersting video...");
        video3.AddComment(makeup1);
        Comment makeup2 = new Comment("Grandpappy1958", "Is this the Google?");
        video3.AddComment(makeup2);
        Comment makeup3 = new Comment("NotSupremeCourt", "Gribshorn! You posted this on Human YouTube! You fool!");
        video3.AddComment(makeup3);

        Video video4 = new Video("Reaction to Makeup vlog 42342: Actual Evidence!!!@!!!", "RealTrueNews", 54000);
        videos.Add(video4);
        
        Comment reaction1 = new Comment("MyOtherCatisaCat", "This can't be real!");
        video4.AddComment(reaction1);
        Comment reaction2 = new Comment("Grandpappy1958", "He knows too much!");
        video4.AddComment(reaction2);
        Comment reaction3 = new Comment("NotSupremeCourt", "Gribshorn! You have been compromised! Get this scrubbed!");
        video4.AddComment(reaction3);
        
        foreach(Video video in videos){
            Console.WriteLine($"\n{video.DisplayInfo()}");
        }
    }
}