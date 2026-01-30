using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Doing it the abstraction way
        //  first video
        Video video1= new Video();
        video1._videoTitle= "How to Make Delicious Jollof Rice";
        video1._videoAuthor= "Nigerian Foodie";
        video1._videoLenInSeconds= "420 seconds";
        Comment comment1a= new Comment();
        comment1a._commentorsName= "FoodLover99";
        comment1a._commentText= "Love  this recipe!";
        Comment comment1b= new Comment();
        comment1b._commentorsName= "Chef in Training";
        comment1b._commentText= "Can i use tomato paste instead?";
        Comment comment1c= new Comment();
        comment1c._commentorsName= "Queen23";
        comment1c._commentText= "Best jollof recipe ever";
        Comment comment1d= new Comment();
        comment1d._commentorsName= "Adam John";
        comment1d._commentText= "How many people does this serve?";
        video1._commentsList.Add(comment1a);
        video1._commentsList.Add(comment1b);
        video1._commentsList.Add(comment1c);
        video1._commentsList.Add(comment1d);

        // second video
        Video video2= new Video();
        video2._videoTitle= "Top 10 Tech Gadget in Nigeria 2025";
        video2._videoAuthor= "TechWithTina";
        video2._videoLenInSeconds= "900 seconds";
        Comment comment2a= new Comment();
        comment2a._commentorsName= "Godson Sam";
        comment2a._commentText= "Thanks for the review!";
        Comment comment2b= new Comment();
        comment2b._commentorsName= "Kelly Johnson";
        comment2b._commentText= "Tecno is better than infinix";
        Comment comment2c= new Comment();
        comment2c._commentorsName= "Hezekiah88";
        comment2c._commentText= "When is the next video?";
        video2._commentsList.Add(comment2a);
        video2._commentsList.Add(comment2b);
        video2._commentsList.Add(comment2c);

        // 3rd video
        Video video3= new Video();
        video3._videoTitle= "Cultural festival in Nigeria";
        video3._videoAuthor= "CultureConnect";
        video3._videoLenInSeconds= "600 seconds";
        Comment comment3a= new Comment();
        comment3a._commentorsName= "Glory Dan";
        comment3a._commentText= "Ebelebe is the best, i love it!";
        Comment comment3b= new Comment();
        comment3b._commentorsName= "Peace Inyang";
        comment3b._commentText= "I love learning about culture.";
        Comment comment3c= new Comment();
        comment3c._commentorsName= "Esther6288";
        comment3c._commentText= "More  on Edo festival please!";
        Comment comment3d= new Comment();
        comment3d._commentorsName= "Abasifreke Akpan";
        comment3d._commentText= "The last time i attended Edo festival, i really enjoyed myself with my friends. Looking forward to it  this year";
        video3._commentsList.Add(comment3a);
        video3._commentsList.Add(comment3b);
        video3._commentsList.Add(comment3c);
        video3._commentsList.Add(comment3d);

        List<Video> _videoList= new List<Video>();
        _videoList.Add(video1);
        _videoList.Add(video2);
        _videoList.Add(video3);

        foreach (Video video in _videoList)
        {
            video.DisplayVideos();
        }
    }
}