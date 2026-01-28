using System;

class Video
{
    // Doing it the abstraction way
    public string _videoTitle;
    public string _videoAuthor;
    public string _videoLenInSeconds;
    public List<Comment> _commentsList= new List<Comment>();

    // public void CommentsOnVideo()
    // {
    //     foreach (Comment comment in _commentsList)
    //     {
    //         comment.CommentInfo();
    //     }
    // }
    public void VideoInfo()
    {
        Console.WriteLine("----- Video Review -----");
        Console.WriteLine($"Video: {_videoTitle}\nAuthor: {_videoAuthor}\nLength: {_videoLenInSeconds} Seconds\n");
    }

    public void DisplayAllCommentOnVideo()
    {
        Console.WriteLine("----- Comments on video -----");
        foreach (Comment comment in _commentsList)
        {
            Console.WriteLine($"{comment.CommentInfo()}");
        }
    }

    public void TotalCommentOnVideo()
    {
        int numberOfComment= _commentsList.Count();
        Console.WriteLine($"Total comment on this video: {numberOfComment}");
        Console.WriteLine("------------------------------------");
        Console.WriteLine();

    }

    public void DisplayVideos()
    {
        VideoInfo();
        DisplayAllCommentOnVideo();
        TotalCommentOnVideo();
    }
}