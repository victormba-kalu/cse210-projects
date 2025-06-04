using System;

namespace ScriptureMemorizer
// I'm using namespaces to group all my programs together. It's not really necessary here since this is a small project but I like the concept

{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int? _endVerse; 

       
        public Reference(string book, int chapter, int verse)
        {
            _book = book ?? throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            _chapter = chapter;
            _verse = verse;
            _endVerse = null; 
        }

      
        public Reference(string book, int chapter, int verse, int endVerse)
        {
            // I use the "throw new ArgumentNullException..." to make sure that my book name is valid
            // If the book name isn't valid, the code does not break but returns a clean error message
            _book = book ?? throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }

        
        public string GetDisplayText()
        {
            if (_endVerse.HasValue)
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse.Value}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}";
            }
        }
    }
}