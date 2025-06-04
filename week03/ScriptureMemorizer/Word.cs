using System;

// I'm using namespaces to group all my programs together. It's not really necessary here since this is a small project but I like the concept
namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor: Initializes the word text and sets its initial visibility to true (shown).
        public Word(string text)
        {
            // I use the "throw new ArgumentNullException..." to make sure that my word object is not created in an invalid state
            _text = text ?? throw new ArgumentNullException(nameof(text), "Word text cannot be null.");
            _isHidden = false; // By default, a new word is visible
        }

        // Behavior: Hides the word by setting _isHidden to true.
        public void Hide()
        {
            _isHidden = true;
        }

        // Behavior: Shows the word by setting _isHidden to false. (Included for completeness, though not strictly required by core specs)
        public void Show()
        {
            _isHidden = false;
        }

        // Behavior: Returns true if the word is hidden, false otherwise.
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Behavior: Returns the word's text or underscores if it's hidden.
        public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }
}