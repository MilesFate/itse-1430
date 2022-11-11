// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace CharacterCreator.Player
{
    /// <summary>Provides access to the standard professions.</summary>
    public static class StandardProfessions
    {
        /// <summary>Gets the standard professions.</summary>
        public static Profession[] Professions { get => s_professions; }

        /// <summary>Fighter</summary>
        public static Profession Sniper = new Profession("Sniper");

        /// <summary>Hunter</summary>
        public static Profession Hunter = new Profession("Hunter");

        /// <summary>Priest</summary>
        public static Profession Assassin = new Profession("Assassin");

        /// <summary>Rogue</summary>
        public static Profession Mage = new Profession("Mage");

        /// <summary>Wizard</summary>
        public static Profession Wizard = new Profession("Chapo");


        #region Private Members

        private static readonly Profession[] s_professions = new Profession[] { Sniper, Hunter, Assassin, Mage, Wizard };

        #endregion
    }
}
