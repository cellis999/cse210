namespace foundation1;
class Comment
{
    string name;
    string text;
    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{name}: {text}");
    }
}