using System;
using System.Collections.Generic; 

namespace YouTubeVideoTracker
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds; // Length of the video in seconds
        private List<Comment> _comments; // Composition: Video has a list of Comments

        public Video(string title, string author, int lengthInSeconds)
        {
            // Using null checks to ensure the video has a valid title and author. Makes the program robust
            _title = title ?? throw new ArgumentNullException(nameof(title), "Video title cannot be null.");
            _author = author ?? throw new ArgumentNullException(nameof(author), "Video author cannot be null.");

            if (lengthInSeconds < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(lengthInSeconds), "Video length cannot be negative.");
            }
            _lengthInSeconds = lengthInSeconds;

            // Initializing the comments list to avoid null reference exceptions
            _comments = new List<Comment>();
            
        }

        
        public void AddComment(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment), "Cannot add a null comment.");
            }
            _comments.Add(comment);
        }

     
        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        // Public getters for video details
        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthInSeconds()
        {
            return _lengthInSeconds;
        }

        
        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}