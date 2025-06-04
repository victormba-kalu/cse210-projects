using System;
using System.Collections.Generic;

// I'm using LINQ - Language Integrated Query so that I can write a robust application that uses powerful methods like Where, Select and All
using System.Linq; 

namespace ScriptureMemorizer
// I'm using namespaces to group all my programs together. It's not really necessary here since this is a small project but I like the concept

{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random; // For selecting random words

        public Scripture(Reference reference, string text)
        {
            _reference = reference ?? throw new ArgumentNullException(nameof(reference), "Reference cannot be null.");
            _random = new Random();

            _words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(wordText => new Word(CleanWord(wordText)))
                         .ToList();
        }

        
        private string CleanWord(string word)
        {
            word = word.TrimEnd('.', ',', ';', ':', '!', '?');
            return word;
        }

       
        public void HideRandomWords(int numberToHide)
        {
            List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();

           
            if (unhiddenWords.Count == 0)
            {
                return;
            }

            
            int actualWordsToHide = Math.Min(numberToHide, unhiddenWords.Count);

            for (int i = 0; i < actualWordsToHide; i++)
            {
                int indexToHide = _random.Next(0, unhiddenWords.Count);
                unhiddenWords[indexToHide].Hide();

               
                unhiddenWords.RemoveAt(indexToHide);
            }
        }

        
        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
            return $"{_reference.GetDisplayText()}\n{scriptureText}";
        }

        
        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
}