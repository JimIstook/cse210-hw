using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Esau's Stew", "Jacob", 30);
        Video video2 = new Video("Flocks and Arms", "Ammon", 1200);
        Video video3 = new Video("Tied to The Mast", "Nephi", 300);
        Video video4 = new Video("On The Wall", "Samuel", 600);
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.AddComment("Esau", "This video is trash");
            video.AddComment("BrotherOfJared", "This really moved me");
            video.AddComment("Noah", "This doesn't even compare to building an ark");
            video.AddComment("Daniel", "It's cool, but can you imagine being in a lion's den?");
        }

        foreach (Video video in videos)
        {
            video.ShowDetails();
        }
    }
}