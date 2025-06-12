using System;

namespace StudentAssignmentSystem
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)

        {
            // Null check for title
            _title = title ?? throw new ArgumentNullException(nameof(title), "title cannot be null.");
        }

        // Method to get the student's name
        public string GetName()
        {

            // Assuming the base class Assignment has a method to get the student's name
            // Gets a trimmed version of the first value in the list returned by splitting GetSummary by '-'
            return base.GetSummary().Split('-')[0].Trim();
        }

        // Method to get the summary of the writing assignment
        public string GetWritingInformation()
        {
            return $"{_title} by {GetName()}";
        }
        
    }
}