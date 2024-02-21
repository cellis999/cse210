namespace Learning04;
class Assignment
{
    // DECLARING VARIABLES
    private string name;
    private string topic;


    // CONSTRUCTOR
    public Assignment(string name, string topic)
    {
        this.name = name;
        this.topic = topic;
    }


    // METHOD
    public string GetSummary()
    {
        string summary = $"{name} - {topic}";
        return summary;
    }
}