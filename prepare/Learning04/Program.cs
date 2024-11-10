using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");
        
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment1 = new MathAssignment();
        mathassignment1.SetStudentName("Roberto Rodriguez");
        mathassignment1.SetTopic("Fractions");
        mathassignment1.SetTextbookSection("7.3");
        mathassignment1.SetProblems("8-19");

        Console.WriteLine(mathassignment1.GetSummary());
        Console.WriteLine(mathassignment1.GetHomeworkList());

        WritingAssignment writingassignment1 = new WritingAssignment();
        writingassignment1.SetStudentName("Mary Waters");
        writingassignment1.SetTopic("European History");
        writingassignment1.SetTitle("The Causes of World War II by Mary Waters");

        Console.WriteLine(writingassignment1.GetWritingInformation());

    }
}