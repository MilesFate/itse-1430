// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

using LuisalbertoCastaneda.AdventureGame.World;

namespace CharacterCreator.Player
{
    public class RepresentPlayer
    {
        public RepresentPlayer ()
        {
            var playerChatacer = new Character()?.repPlayer();
            var playerInventory = new Item();
        }

        public int placeX { get; set; }
        public int placeY { get; set; }
        
        public const int MaximumX = 3;
        public const int MaximumY = 3;
    }
}
