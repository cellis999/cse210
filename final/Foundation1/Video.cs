using System.Transactions;

namespace foundation1;

class Video
{
    public Video(string video, string author, int length)
    {
        this.video = video;
        this.author = author;
        this.length = length;
    }
    string video;
    string author;
    int length;
    List<Comment> comments = new List<Comment>();

    public void AddComment(string username, string words)
    {
        comments.Add(new Comment(username, words));
    }
    public void Display()
    {
        Console.WriteLine($"Video: {video}, By: {author}, {length} seconds\n# of comments: {comments.Count()}");
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }
}
