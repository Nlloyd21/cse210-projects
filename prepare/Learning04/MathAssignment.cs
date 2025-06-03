class MathAssignment : Assignment
{
    private string _textookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic)
    {
        _textookSection = textbookSection;
        _problems = problems;
    }
    public string GetTextbookSection()
    {
        return _textookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textookSection} Problems {_problems}";
    }
}