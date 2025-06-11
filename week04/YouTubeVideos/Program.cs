using System;
using System.Collections.Generic; 

namespace YouTubeVideoTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- My Youtube Video Tracker Demo ---");
            Console.WriteLine("-------------------------------------------");

            List<Video> videos = new List<Video>();

         
            Video video1 = new Video("Sustainable Farming Practices in Osun State", "Terra Balance TV", 720); 
            video1.AddComment(new Comment("Farmer Ade", "This was so insightful! Love the tips on organic fertilizer."));
            video1.AddComment(new Comment("GreenThumb Guru", "Excellent content! What about water harvesting techniques?"));
            video1.AddComment(new Comment("Community Watch", "Proud of what Terra Balance is doing in our community."));
            video1.AddComment(new Comment("AgriTech Enthusiast", "Any plans for a video on precision agriculture tools?"));
            videos.Add(video1);

          
            Video video2 = new Video("The Journey of Organic Cocoa from Farm to Bar", "Cocoa Connoisseur", 1800); 
            video2.AddComment(new Comment("Chocoholic", "Absolutely fascinating! Now I appreciate my chocolate even more."));
            video2.AddComment(new Comment("Sustainable Biz", "Great insights into ethical sourcing. Inspiring!"));
            video2.AddComment(new Comment("Local Artisan", "Where can I buy Terra Balance's organic cocoa beans?"));
            videos.Add(video2);

            
            Video video4 = new Video("Youth Empowerment through Agribusiness", "Osun Youth Dev", 1080); 
            video4.AddComment(new Comment("Aspiring Farmer", "Motivating video! How can I join these programs?"));
            video4.AddComment(new Comment("Policy Maker", "Excellent model for rural development."));
            video4.AddComment(new Comment("Parent", "My children need to see this. Great initiative."));
            videos.Add(video4);


            foreach (Video video in videos)
            {
                Console.WriteLine($"\n--- Video Details ---");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

                Console.WriteLine("Comments:");
                
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.GetCommenterName()}: \"{comment.GetCommentText()}\"");
                }
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("--- Demonstration Complete ---");

            // Wait for user input before closing the console window
            // User input can be any keystroke
            // This gives the user time to read the output before the console closes
            Console.ReadKey();
        }
    }
}