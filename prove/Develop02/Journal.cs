using System.ComponentModel;
using System.IO;
public class Journal
    {
        //Class variables
        public string _userName;
        
        //Class for entries//
        public List<Entry> _userEntry;
        public string _newEntry;

        //Constructor//
        public Journal(string userName)
        {
            _userName = userName;
            _userEntry = new List<Entry>();
        }

        //Functions//

        //Get User Entry//

        public void NewEntry()
        {
            string prompt = RandomPrompt();
            string response = Console.ReadLine();
            DateTime intDate = DateTime.Now;
            string currentDate = intDate.ToShortDateString();
            Entry entry = new Entry(currentDate,prompt,response);
            _userEntry.Add(entry);  
        }
        public void DisplayAll()
        {

            foreach (var i in _userEntry)
            {
                Console.WriteLine(i.EntireEntry());
            }

        }
        public void SaveJournal()
        {
            string fileName = _userName + "journal.txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (var i in _userEntry)
                {
                    outputFile.WriteLine(i.EntireEntry());
                }


            }
        }

        public void LoadJournal()
        {
            string filename = _userName + "journal.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                
                string[] parts = line.Split(",");

                string entryDate = parts[0];
                string entryPrompt = parts[1];
                string entryEntry = parts[2];

                Entry entry = new Entry(entryDate, entryPrompt, entryEntry);
                _userEntry.Add(entry);
            }
        }

        string RandomPrompt()
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
    }