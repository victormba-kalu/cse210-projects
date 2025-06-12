using System;
namespace StudentAssignmentSystem
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string studentName, string topic, string textbookSection, string problems)
            : base(studentName, topic)
        {
            // Null checks for member variables
            _textbookSection = textbookSection ?? throw new ArgumentNullException(nameof(textbookSection), "textbookSection cannot be null.");
            _problems = problems ?? throw new ArgumentNullException(nameof(problems), "problems cannot be null.");
        }

        // Method to get homework details

        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}