using System;

public class Reflection : Activity
{
    //class variables//
    private List<string> _prompt;
    private List<string> _question;
    private List<string> _input;
    private Random _random;
    private string _listPrompt;
    private string _listQuestion;

    //constructors//
    public Reflection(int activityChoice) : base(activityChoice)
    {
        _prompt = new List<string>
        {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        };

        _question = new List<string>
        {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was completed?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        };

        _input = new List<string>();
        _random = new Random();
        Console.WriteLine("Reflection constructor executed.");

    }

    //methods//
    public string RandomPrompt()
    {
        int index = _random.Next(_prompt.Count);
        string _listPrompt = _prompt[index];
        return _listPrompt;
    }
    
    public string RandomQuestion()
    {
        if (_question.Count == 0)
        {
            return "";
        }
        
        int index = _random.Next(_question.Count);
        string _listQuestion = _question[index];
        _question.RemoveAt(index);
        return _listQuestion;
        
    }
    
    public void ReflectionInput()
    {
        Console.WriteLine($"{_listPrompt}");
        _listQuestion = RandomQuestion();

        Console.WriteLine($"{_listQuestion}");
        Console.Write("> ");
        string userInput = Console.ReadLine();
        _input.Add(userInput);
    }

    //public void PromptMessage(string _listPrompt, string _listQuestion)
    //{
        //Console.Clear();
        //Console.WriteLine("");
        //Console.WriteLine($"{_listPrompt}");
        //Console.WriteLine($"{_listQuestion}");
    //}

    public void RunReflection(int activityLength)
    {
        _listPrompt = RandomPrompt();
        //_listQuestion = RandomQuestion();
        Console.Clear();
        Console.WriteLine("\nGet ready.");
        SleepSpinner();
        Console.WriteLine("Consider the following: ");
        Console.WriteLine($"{_listPrompt}");

        Console.WriteLine("\nPress enter when you are ready.");
        Console.ReadLine();

        DateTime futureTime = DateTime.Now.AddSeconds(activityLength);

        while (DateTime.Now < futureTime)
        {
            Console.Clear();
            ReflectionInput();
            if (string.IsNullOrEmpty(_listQuestion))
            {
                Console.WriteLine("You answered all of the questions.");
                break;
            }
        }

        EndMessage();
    }

}