    public class Entry
    {
        //variables withing the class//
        public string _currentEntry;
        public string _currentPrompt;
        public string _currentDate;

        //constructor//
        public Entry(string date, string prompt, string entry)
        {
            _currentDate = date;
            _currentPrompt = prompt;
            _currentEntry = entry;
        }


        //functions within the class//
        
        //GetEntry function//

        string GetEntry()
        {
            string _userEntry = Console.ReadLine();
            return _userEntry;
        }
        
        //GetDate Function//
        string GetDate()
        {
            DateTime intDate = DateTime.Now;
            string currentDate = intDate.ToShortDateString();
            return currentDate;
        }

        //Display single entry function//
        void DisplayEntry(string _currentDate, string _currentPrompt, string _currentEntry)
        {
            Console.WriteLine($"Date: {_currentDate}");
            Console.WriteLine(_currentPrompt);
            Console.WriteLine(_currentEntry);
            Console.WriteLine("");
        }

        public string EntireEntry()
        {
            return _currentDate + "," + _currentPrompt + "," + _currentEntry;
        }
    }

    