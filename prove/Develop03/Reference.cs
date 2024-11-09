using System.Collections.Concurrent;
using System.Data;

namespace ScriptureMemory
{
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verse;
        private string _endVerse;
        private string _text;

        private static Reference[] scriptures = new Reference[]
        {
            new Reference("John", "3", "5", "", "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."),
            new Reference("Proverbs", "3", "5", "6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Reference("Malachi", "4", "5", "6", "Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the Lord: And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse."),
            new Reference("Doctrine and Covenants", "10", "5", "","Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.")
        };

        public Reference(string book, string chapter, string verse, string endVerse, string text)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
            _text = text;
        }

        public static Reference RandomScripture()
        {
            Random random = new Random();
            int index = random.Next(scriptures.Length);
            return scriptures[index];
        }

        public string FullText()
        {
            return _text;
        }
        
        public string DisplayScripture()
        {
            if (string.IsNullOrEmpty(_endVerse))
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
        }

        public string GetText()
        {
            return _text;
        }
    }
}