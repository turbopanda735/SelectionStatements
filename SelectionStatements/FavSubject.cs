using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class FavSubject
    {
        public void UserSubject()
        {
            Console.WriteLine("what is your favorite school subject?");
            Console.WriteLine("acceptable inputs are: History, Math, English, Science, and Art");
            var schoolSubject = Console.ReadLine();
            switch (schoolSubject.ToLower())
            {
                case "history":
                    Console.WriteLine("history? this is my favorite... what a good pick. what a great person you must be. i love you.");
                    break;
                case "math":
                    Console.WriteLine("math? really? gross... >:(");
                    break;
                case "english":
                    Console.WriteLine("to be or not to be...");
                    break;
                case "science":
                    Console.WriteLine("i studied biology in school. plant and soil sciences. pretty good pick.");
                    break;
                case "art":
                    Console.WriteLine("i am not good at it but i appreciate that it's your favorite.");
                    break;
                default:
                    Console.WriteLine("an error has occured, please try again");
                    break;
            }
        }
    }
}
