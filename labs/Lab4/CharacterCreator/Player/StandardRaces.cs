// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace CharacterCreator.Player
{
    /// <summary>Provides access to the standard races.</summary>
    public static class StandardRaces
    {
        /// <summary>Gets the standard races.</summary>
        public static Race[] Races { get => s_races; }

        /// <summary>Dwarf</summary>
        public static Race Zeno = new Race("Zeno");

        /// <summary>Elf</summary>
        public static Race Human = new Race("Human");

        /// <summary>Gnome</summary>
        public static Race Raccoon = new Race("Raccoon");

        /// <summary>Half-Elf</summary>
        public static Race Robot = new Race("Robot");

        /// <summary>Human</summary>
        public static Race Monster = new Race("Monster");

        #region Private Members

        private static readonly Race[] s_races = new Race[] { Zeno, Human, Raccoon, Robot, Monster };

        #endregion
    }
}
