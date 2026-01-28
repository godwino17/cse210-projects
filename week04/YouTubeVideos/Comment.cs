using System;

class Comment
{
    // Doing it the abstraction way
    public string _commentorsName;
    public string _commentText;

    public string CommentInfo()
    {
        return $"Name: {_commentorsName}\nComment: {_commentText}\n";
    }
}