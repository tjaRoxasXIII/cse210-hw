using System;


class Program
{
    static void Main(string[] args)
    {
        List<string> commentList = ["Wow, great video!", "This was fun to watch!", "I could have made a better video blindfolded...", "Never watching this again", "Ur vid was gr8!", "Please follow my channel", "This bored me.", "Mad respect!", "The moment at 0:55 was pure gold", "You should do more stuff like this."]; 
        List<string> usernameList = ["Jake1234", "WizKid", "sparkleKnight", "coolnessabc123", "John_Graham", "Your Average Rockstar", "ChickenChaser", "LadyGaga's Left Shoe"];

        List<Video> videos = new List<Video>();

        Video video1 = new Video("PC Build Tutorial", "LTT", 1440);
        Video video2 = new Video("Beast Games Episode 30", "Mr Beast", 1500);
        Video video3 = new Video("How to replace a windshield", "TheCarGuy", 807);
        Video video4 = new Video("Coding For Dummies", "anonymous python", 601);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach(Video video in videos)
        {
            Random rand = new Random();
            int numComments = rand.Next(3, 5);
            int i = 0;
            while(i < numComments)
            {
                int commentIndex = rand.Next(commentList.Count());
                int usernameIndex = rand.Next(usernameList.Count());

                video.addComment(new Comment(usernameList[usernameIndex], commentList[commentIndex]));
                i++;
            }
            
            video.DisplayVideoText();
            Console.WriteLine("------------\n\n");
        }



    }

}