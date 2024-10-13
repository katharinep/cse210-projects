    public class Entry
    {
        //variables withing the class//
        public string _currentEntry;
        public string _currentPrompt;
        public string _currentDate;

        //consturctor//
        public Entry()
        {
        }


        //functions within the class//
        
        //RandomPrompt Function//
        static string RandomPrompt()
        {
            //Prompt list//
            var prompts = new List<string> 
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            //Generate random prompt//
            var random = new Random();
            int index = random.Next(prompts.Count);
            string _currentPrompt = prompts[index];
            Console.WriteLine(_currentPrompt);

            return _currentPrompt;
            //list help from: https://www.c-sharpcorner.com/article/c-sharp-list///
            //random help from: https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list//
        }

        //GetEntry function//

        static string GetEntry()
        {
            string _userEntry = Console.ReadLine();
            return _userEntry;
        }
        
        //GetDate Function//
        static string GetDate()
        {
            DateTime intDate = DateTime.Now;
            string currentDate = intDate.ToShortDateString();
            return currentDate;
        }

        //Display single entry function//
        static void DisplayEntry(string _currentDate, string _currentPrompt, string _currentEntry)
        {
            Console.WriteLine($"Date: {_currentDate}");
            Console.WriteLine(_currentPrompt);
            Console.WriteLine(_currentEntry);
            Console.WriteLine("");
        }
    }

    