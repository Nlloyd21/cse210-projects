class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingAssignment()
    {
        return $"{_title} by {_studentName}";
    }
    
}