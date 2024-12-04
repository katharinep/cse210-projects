public class Video
{
    public string VideoTitle;
    public string VideoAuthor;
    public int VideoLength;
    public List<Comment> Comments;
    
    public Video(string videotitle, string videoauthor, int videolength)
    {
        VideoTitle = videotitle;
        VideoAuthor = videoauthor;
        VideoLength = videolength;
        Comments = new List<Comment>();
    }

    public int CommentNumber()
    {
        return Comments.Count;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}