using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video();
        video1._title = "Intro to Programming";
        video1._author = "ProgrammingGuru25";
        video1._length = 600;

        Comment comment1 = new Comment();
        comment1._user = "JCampos";
        comment1._text = "This was so easy to understand! Thank You!";

        Comment comment2 = new Comment();
        comment2._user = "MRoberts";
        comment2._text = "And to think my instructor in College made it look so hard.";

        Comment comment3 = new Comment();
        comment3._user = "RandomUser19";
        comment3._text = "Booooring!";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Variables and Functions";
        video2._author = "ProgrammingGuru25";
        video2._length = 720;

        Comment comment4 = new Comment();
        comment4._user = "JCampos";
        comment4._text = "Simple and direct to the point. I love you videos!";

        Comment comment5 = new Comment();
        comment5._user = "Anonymous";
        comment5._text = "I don't get it... what are those for?";

        Comment comment6 = new Comment();
        comment6._user = "RandomUser19";
        comment6._text = "Your voice annoys me.";

        Comment comment7 = new Comment();
        comment7._user = "MRoberts";
        comment7._text = "I'm really learning more with this videos than with my textbook.";

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Introduction to Classes";
        video3._author = "ProgrammingGuru25";
        video3._length = 1860;

        Comment comment8 = new Comment();
        comment8._user = "MRoberts";
        comment8._text = "I wish you would replace my teacher at College";

        Comment comment9 = new Comment();
        comment9._user = "RandomUser19";
        comment9._text = "This is so useless. You should stop making videos.";

        Comment comment10 = new Comment();
        comment10._user = "JCampos";
        comment10._text = "Amazing! This makes programming so much easier!";

        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);

        videos.Add(video3);

        Console.Clear();
        foreach (Video video in videos)
        video.DisplayVideoInformation();
    }
}