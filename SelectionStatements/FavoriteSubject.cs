using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("what is your favorite school subject?");
        Console.WriteLine("acceptable inputs are: History, Math, English, Science, and Art")
            string favSubject = Console.ReadLine();
        switch (favSubject)
        {
            case "History":
                Console.WriteLine("history? this is my favorite... what a good pick. what a great person you must be. i love you.");
                break;
            case "Math":
                Console.WriteLine("math? really? gross... >:(");
                break;
            case "English":
                Console.WriteLine("to be or not to be... english is my first language so i never learned it in school");
                break;
            case "Science":
                Console.WriteLine("i studied biology in school. plant and soil sciences. pretty good pick.");
                break;
            case "Art":
                Console.WriteLine("i am not good at it but i appreciate that it's your favorite.");
                break;
            default:
                Console.WriteLine("thats not one of the acceptable school subjects.");
                break;
        }
}
