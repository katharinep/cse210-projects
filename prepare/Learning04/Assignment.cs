using System;

public class Assignment
{
    //class variables//
    protected string _studentName = "";
    protected string _topic = "";

    //constructors//
    public Assignment()
    {
        _studentName = "";
        _topic = "";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    //getters and setters//
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    
    //methods//
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}