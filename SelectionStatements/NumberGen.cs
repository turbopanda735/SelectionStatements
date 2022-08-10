using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class NumberGen
    {
        public void GuessMe()
        {
            Console.WriteLine("try to guess my favorite number! hint: it is between one and ten!!!");
            var r = new Random();
            var favNumber = r.Next(1, 10);
            bool correctAnswer = false;
            while (correctAnswer == false)
            {
                var userInput = int.Parse(Console.ReadLine());
                bool userAnswer = UserGuesser(favNumber, userInput);
                if (userAnswer == true)
                    break;
            }
        }
        bool UserGuesser(int y, int z)
        {
            int favoriteNumber = y;
            int userGuess = z;
            if (userGuess > favoriteNumber)
            {
                Console.WriteLine("too high :(");
                return false;
            }
            else if (userGuess < favoriteNumber)
            {
                Console.WriteLine("too low :(");
                return false;
            }
            else
            {
                Console.WriteLine("you got it!!!");
                return true;
            }
        }
    }
}

