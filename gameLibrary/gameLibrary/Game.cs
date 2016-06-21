using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLibrary
{
    class Game
    {
        public string title;
        public string genre;
        public string ageRating;
        public string platform;
        public int price;

        public static int totalGames = 0;



        public Game(string title, string genre, string ageRating, string platform, int price)
        {
            this.title = title;
            this.genre = genre;
            this.ageRating = ageRating;
            this.platform = platform;
            this.price = price;
            totalGames += 1;
        }
        public void sellGame()
        {
            Console.WriteLine("We sold {0} for £{1}.", this.title, this.price);
        }
        public static void numOfGames()
        {
            Console.WriteLine("We have {0} game in stock.", totalGames);
        }




    }

}