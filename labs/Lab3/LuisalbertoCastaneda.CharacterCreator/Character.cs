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

        public string Validate ()
        {

            if (String.IsNullOrEmpty(Name))           
                return "Name is required";

            if (String.IsNullOrEmpty(Biography))
                return "Biography is required";

            if (Strength < 0 || Strength > 100)
                return "Run Length must be Between 0 - 100";

            if (Intelligence < 0 || Intelligence > 100)
                return "Run Length must be Between 0 - 100";

            if (Agility < 0 || Agility > 100)
                return "Run Length must be Between 0 - 100";

            if (Constitution < 0 || Constitution > 100)
                return "Run Length must be Between 0 - 100";

            if (Charisma < 0 || Charisma > 100)
                return "Charisma must be Between 0 - 100";

            if (String.IsNullOrEmpty(Profession))
                return "Profession is required";

            if (String.IsNullOrEmpty(Race))
                return "Race is required";

            return null;
        }
    }
}
