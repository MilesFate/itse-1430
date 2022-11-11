/*
 * Luisalberto Castaneda
 * ITSE-1430
 * Lab2 - Character Creator
 */
using System;

namespace LuisalbertoCastaneda.CharacterCreator
{
    /// <summary> Represents a Character </summary>
    public class Character
    {
        private string _name;
        private string _profession;
        private string _race;
        private string _biography;

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim(); }
        }

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value?.Trim(); }
        }

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value?.Trim(); }
        }

        public string Biography
        {
            get { return _biography ?? ""; }
            set { _biography = value?.Trim(); }
        }

        public const int maximumValue = 100, minimumValue = 1;

        public int Strength { get; set; } = minimumValue;

        public int Intelligence { get; set; } = minimumValue;

        public int Agility { get; set; } = minimumValue;

        public int Constitution { get; set; } = minimumValue;

        public int Charisma { get; set; } = minimumValue;
    }
}
