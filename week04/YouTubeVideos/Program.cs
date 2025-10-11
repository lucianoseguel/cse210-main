using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello this is the Youtube viewer.");
        // First Video
        Videos video_1 = new Videos();
        video_1.SetVideo("Cells Explained: A Journey Inside Life", "6:59", "Elia Montes (Molecular Biologist)");

        //Adding comments
        video_1.AddComment("@Astro_Rookie", "Amazing explanation! I finally understand the difference between the waxing and waning gibbous. Could you do a short video next on the tides and how the moon affects them?");
        video_1.AddComment("@Teacher_Sara", "This video is a lifesaver for my 4th-grade science project. The animations made the concept so clear. Thank you, Prof. Stellar!");
        video_1.AddComment("@Cosmic_Joker", "I thought I knew this, but I totally failed the 2-minute quiz in my head. Guess I'll be rewatching this until I can name all 8 phases backwards! 😅");


        //Second Video
        Videos video_2 = new Videos();
        video_2.SetVideo("The Power of Compound Sentences: Level Up Your Writing!", "07:35", "Ms. Read-a-Lot (English & Grammar Coach)");
        
        //Adding 2nd comments
        video_2.AddComment("@EssayWhiz", "I always mixed up compound and complex sentences. The FANBOYS acronym is a game-changer! My essays already sound much better. Great tips, Ms. Read-a-Lot.");
        video_2.AddComment("@TheBookworm", "Short and super helpful! Can we get a video on misplaced modifiers next? That's always where my writing gets messy. 😩");
        video_2.AddComment("@GrammarGuru_77", "Subscribed! This is the most practical grammar lesson I've seen on YouTube. Keep these quick tutorials coming!");


        //Third Video 
        Videos video_3 = new Videos();
        video_3.SetVideo("Microeconomics 101: What is 'Supply and Demand'?", "09:50", "Econ Insights (Financial Literacy Channel)");
         
         //Adding comments
         video_3.AddComment("@Market_Minder", "The concept of the 'equilibrium price' has never been so simple. I struggled with this in college, and this video explained it in 9 minutes. Incredible job, Econ Insights!");
        video_3.AddComment("@BizStudentLA", "Interesting! So the current high price of avocados is a perfect real-world example of demand increasing faster than supply can keep up. 🤔 Thanks for breaking down the theory.");
        video_3.AddComment("@Future_CEO", "This should be mandatory viewing for anyone starting a business. Understanding the curve helps make so many decisions. Very high-quality educational content!");

        video_1.GetVideo();
        video_2.GetVideo();
        video_3.GetVideo();
    }




    public class Videos
    {
        public string _video_name = "New Video";

        public string _duration = "0:00";
        public string _author = "user";

        List<Comment> Comments = new List<Comment>();

        public void SetVideo(string name, string duration, string author)
        {
            _video_name = name;
            _duration = duration;
            _author = author;

        }

        public void SetVideo()
        {
            _video_name = "New Video";
            _duration = "0:00";
            _author = "user";
        }

        public void AddComment(string user, string text)
        {
            Comment comentary = new Comment();
            comentary.SetComment(user, text);
            Comments.Add(comentary);
        }

        public void GetVideo()
        {
            Console.WriteLine($" Title: {_video_name} \n Duration: {_duration} \n Author: {_author} \n \n");

            if (Comments != null)
            {

                for (int i = 0; i < Comments.Count(); i++)
                {
                    Console.WriteLine($"{Comments[i].DisplayComment()}");
                }
            }
            
        }
        
        



    }
    
    public class Comment
    {
        public string _user;
        public string _text;

        public void SetComment(string user, string text)
        {
            _user = user;
            _text = text;
        }

        public void SetComment()
        {
            _user = "Unknown";
            _text = "";
        }

        public string DisplayComment()
        {
            return $"{_user}: {_text}";
        }
    
    }
}