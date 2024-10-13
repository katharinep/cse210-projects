public class Journal
    {
        //Class variables
        string _userName;
        
        //Class for entries//
        public class UserEntry
        {

        }

        //Constructor//
        public Journal()
        {
        }

        //Functions//
        //Get user name//
        static string GetUserName()
        {
            Console.WriteLine("What is the user name? ");
            string _userName = Console.ReadLine();
            return _userName;
        }

        //Get User Entry//

        static string GetUserEntry()
        {

        }
        static void DisplayAll()
        {
            //work on this after working on saving data//
            foreach (string entry in Entry)
                {

                }
        }
    }