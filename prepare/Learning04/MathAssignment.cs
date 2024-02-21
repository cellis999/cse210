namespace Learning04;
class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    // CONSTRUCTOR WITH BASE
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        this.textbookSection = textbookSection;
        this.problems = problems;
    }

    public string GetHomeworkList()
    {
        string homework = $"{textbookSection} {problems}";
        return homework;
    }
}