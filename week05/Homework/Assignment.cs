using System;

namespace StudentAssignmentSystem
{
    public class Assignment
    {
        private string _studentName;
        private string _topic;

        public Assignment(string studentName, string topic)
        {
            // Null checks for member variables
            _studentName = studentName ?? throw new ArgumentNullException(nameof(studentName), "studentName cannot be null.");
            _topic = topic ?? throw new ArgumentNullException(nameof(topic), "topic cannot be null.");
        }

        // Method to get the student's name
        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}