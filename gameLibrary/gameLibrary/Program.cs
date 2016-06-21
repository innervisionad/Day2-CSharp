using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Game warcraft = new Game("World of Warcraft", "MMORPG", "12+", "PC", 30);
            Game halo = new Game("Halo", "Shooter", "15", "Xbox", 45);
            Game uncharted = new Game("uncharted", "Action", "15", "PS4", 45);
            Game zelda = new Game("Zelda", "RPG", "5+", "Wii", 40);


            warcraft.sellGame();
            halo.sellGame();
            uncharted.sellGame();
            zelda.sellGame();






        }
    }
}
