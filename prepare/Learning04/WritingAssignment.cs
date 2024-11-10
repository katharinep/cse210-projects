using System;

public class WritingAssignment : Assignment
{
    //class variables//
    private string _title;

    //getters and setters//
    public void SetTitle(string title)
    {
        _title = title;
    }
    //constructor//
    public WritingAssignment(string title): base()
    {
        _title = title;
    }

    public WritingAssignment() : base()
    {
        _title = "";
    }

    //methods//
    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}