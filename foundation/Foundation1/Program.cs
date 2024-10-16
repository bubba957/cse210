using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Yogurt", "BDubs", 104);
        Comment comment1 = new Comment("xxxMExxx", "Reminds me of rainfall");
        Comment comment2 = new Comment("CrashBandicoot", "Is that a dinosaur? WICKED!!!");
        Comment comment3 = new Comment("THISisMYnameHIII", "Cool you can turn yogurt into eggs.");
        Comment comment4 = new Comment("Breakyou", "I could've done that in my sleep.");
        Console.WriteLine(video1.GetVideoDisplay());
        Console.WriteLine();
        Console.WriteLine(comment1.GetCommentDisplay());
        Console.WriteLine(comment2.GetCommentDisplay());
        Console.WriteLine(comment3.GetCommentDisplay());
        Console.WriteLine(comment4.GetCommentDisplay());
        Console.WriteLine(video1.commentList());

        Console.WriteLine();
        Video video2 = new Video("Redo of my room", "___cods___", 130);
        Comment comment5 = new Comment("84men", "I want that color");
        Comment comment6 = new Comment("Cavewomen", "You are using THAT color!?!");
        Comment comment8 = new Comment("gg66yy", "I have the same plushie");
        Console.WriteLine(video2.GetVideoDisplay());
        Console.WriteLine();
        Console.WriteLine(comment5.GetCommentDisplay());
        Console.WriteLine(comment6.GetCommentDisplay());
        Console.WriteLine(comment8.GetCommentDisplay());
        // Console.WriteLine(video1.commentList());

        Console.WriteLine();
        Video video3 = new Video("Magic Tricks", "Buddy69", 53);
        Comment comment9 = new Comment("killmyjoy", "I will admit those are pretty cool");
        Comment comment10 = new Comment("SpiritofyoU", "That dounut looks downright scrumptious");
        Comment comment12 = new Comment("Doc42", "I am a doctor. Everyone CLEAR.");
        Console.WriteLine(video3.GetVideoDisplay());
        Console.WriteLine();
        Console.WriteLine(comment9.GetCommentDisplay());
        Console.WriteLine(comment10.GetCommentDisplay());
        Console.WriteLine(comment12.GetCommentDisplay());
        // Console.WriteLine(video3.commentList());

        Console.WriteLine();
        Video video4 = new Video("This is my family", "ILoveMyFamily", 10);
        Comment comment13 = new Comment("Gurr", "This is a short video");
        Comment comment14 = new Comment("vvvvvvvvvttt", "I love my family too. You don't see me flaunting them around.");
        Comment comment15 = new Comment("Rawr", "Nice collage");
        Comment comment16 = new Comment("Yaddadii", "And how many family members do you have?");
        Console.WriteLine(video4.GetVideoDisplay());
        Console.WriteLine();
        Console.WriteLine(comment13.GetCommentDisplay());
        Console.WriteLine(comment14.GetCommentDisplay());
        Console.WriteLine(comment15.GetCommentDisplay());
        Console.WriteLine(comment16.GetCommentDisplay());
        // Console.WriteLine(video4.commentList());
    }
}