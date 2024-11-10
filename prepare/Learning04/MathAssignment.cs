using System;

public class MathAssignment : Assignment
{
    //class variables//
    private string _textbookSection;
    private string _problems;

    //getters and setters//
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    //constructors//
    public MathAssignment() : base()
    {
        _textbookSection = "";
        _problems = "";
    }
    public MathAssignment(string textbookSection, string problems) : base()
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //methods//
    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\nSection {_textbookSection} Problems {_problems}";
    }

}