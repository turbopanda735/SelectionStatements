using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main()
        {
            var randomNumber = new NumberGen();
            randomNumber.GuessMe();

            var favoriteSubject = new FavoriteSubject();
            favoriteSubject.UserSubject();
        }
    }
}
