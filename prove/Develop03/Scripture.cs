namespace ScriptureMemory
{
    public class Scripture
    {
        private Reference _reference;
        private Words _words;

        public Scripture()
        {  
            _reference = Reference.RandomScripture();
            _words = new Words(_reference.GetText());
        }

        public void HideWords()
        {
            _words.Hide();
        }

        public string RenderedText()
        {
            return $"{_reference.DisplayScripture()}\n{_words.RenderedText()}";
        }

        public string FullScript()
        {
            return $"{_reference.DisplayScripture()}\n{_reference.FullText()}";
        }

        public bool CompletelyHidden()
        {
            return _words.AllHidden();
        }
    }
}