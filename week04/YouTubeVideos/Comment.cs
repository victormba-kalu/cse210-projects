using System;


// This namespace helps organize my code and avoid naming conflicts. 
namespace YouTubeVideoTracker
{
    public class Comment
    {
        private string _commenterName;
        private string _commentText;

        public Comment(string commenterName, string commentText)
        {
            // Using null checks to keep the program robust
            _commenterName = commenterName ?? throw new ArgumentNullException(nameof(commenterName), "Commenter name cannot be null.");
            _commentText = commentText ?? throw new ArgumentNullException(nameof(commentText), "Comment text cannot be null.");
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }


        public string GetCommentText()
        {
            return _commentText;
        }
    }
}
