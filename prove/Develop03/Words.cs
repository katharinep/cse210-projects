namespace ScriptureMemory
{
    public class Words
    {
        private List<string> wordsList;
        private List<bool> _hiddenWord;
        private Random random = new Random();

        public Words(string text)
        {
            wordsList = new List<string>(text.Split(' '));
            _hiddenWord = new List<bool>(new bool[wordsList.Count]);
        }

        public void Hide()
        {
            int index;
            do
            {
                index = random.Next(wordsList.Count);
            }
            while (_hiddenWord[index]);
                _hiddenWord[index] = true;
        }

        public bool AllHidden()
        {
            return _hiddenWord.TrueForAll(status => status);
        }

        public string RenderedText()
        {
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (_hiddenWord[i])
                {
                    wordsList[i] = "_____";
                }
            }
            return string.Join(" ",wordsList);
        }
    }
}