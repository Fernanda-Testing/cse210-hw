using System;
using System.Linq.Expressions;

class Program
{
    private static List<Video> _videos = new List<Video>(); 
    static void Main(string[] args)
    {
        Video videoOne = new Video("Braveheart & Titanic: Piano Suite - A James Horner Tribute \\ Jacob's Piano", "Jacob's Piano", 6.29);
        Video videoTwo = new Video("Yiruma - River Flows in You", "YIRUMA place / 이루마 official", 3.33);
        Video videoThree = new Video("Ludovico Einaudi - Nuvole Bianche", "Rousseau", 6.40);
        Video videoFour = new Video("Hallelujah - Instrumental (Cover) | Piano Violin Cello", "TRITONIA MUSIC - ViolinCelloPiano - Instrumental", 5);

        Comment firstComment = new Comment("Fernanda", "Beautiful sound");
        Comment secondComment = new Comment("Gabriela", "I like this music a lot");
        Comment thirdComment = new Comment("Teresa", "I can't stop listening to it!");
        Comment fourthComment = new Comment("Facundo", "I don't remember how many times I have heard it, I like it a lot");
       
        videoOne.SaveInListOfComments(firstComment);
        videoOne.SaveInListOfComments(secondComment);
        videoOne.SaveInListOfComments(thirdComment);
        videoOne.SaveInListOfComments(fourthComment);
        
        videoTwo.SaveInListOfComments(firstComment);
        videoTwo.SaveInListOfComments(secondComment);
        videoTwo.SaveInListOfComments(thirdComment);
        videoTwo.SaveInListOfComments(fourthComment);
        
        videoThree.SaveInListOfComments(firstComment);
        videoThree.SaveInListOfComments(secondComment);
        videoThree.SaveInListOfComments(thirdComment);
        videoThree.SaveInListOfComments(fourthComment);
        
        videoFour.SaveInListOfComments(firstComment);
        videoFour.SaveInListOfComments(secondComment);
        videoFour.SaveInListOfComments(thirdComment);
        videoFour.SaveInListOfComments(fourthComment);

        _videos.Add(videoOne);
        _videos.Add(videoTwo);
        _videos.Add(videoThree);
        _videos.Add(videoFour);

        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()} - Author: {video.GetAuthor()} - Duration: {video.GetLength()} mins. \nNumber of comments: {video.GetNumberOfComments()}\nList of Comments: \n{video.DisplayListOfComments()}");            
        }
    }
}