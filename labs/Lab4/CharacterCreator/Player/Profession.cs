// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace CharacterCreator.Player
{
    /// <summary>Represents a profession/career in the game.</summary>
    public class Profession
    {
        public Profession ( string name ) => Name = name ?? "";

        public string Name { get; }
    }
}
