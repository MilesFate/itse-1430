// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace CharacterCreator.Player
{
    /// <summary>Represents a character.</summary>
    public class Character
    {
        /// <summary>Gets the maximum attribute value.</summary>
        public const int MaximumAttributeValue = 100;

        /// <summary>Gets the minimum attribute value.</summary>
        public const int MinimumAttributeValue = 1;

        #region Getters and Setters
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get => _name ?? ""; 
            set => _name = value; 
        }

        /// <summary>Gets or sets the biography.</summary>
        public string Biography
        {
            get => _bio ?? ""; 
            set => _bio = value; 
        }

        /// <summary>Gets or sets the profession.</summary>
        public Profession Profession { get; set; }

        /// <summary>Gets or sets the race.</summary>
        public Race Race { get; set; }

        /// <summary>Gets or sets the strength.</summary>
        public int Strength { get; set; }

        /// <summary>Gets or sets the intelligence.</summary>
        public int Intelligence { get; set; }

        /// <summary>Gets or sets the agility.</summary>
        public int Agility { get; set; }

        /// <summary>Gets or sets the constitution.</summary>
        public int Constitution { get; set; }

        /// <summary>Gets or sets the charisma.</summary>
        public int Charisma { get; set; }

        #endregion

        public bool Validate ( out string errorMessage )
        {
            if (String.IsNullOrEmpty(Name))
            {
                errorMessage = "Name is required";
                return false;
            };

            if (Profession == null)
            {
                errorMessage = "Profession is required";
                return false;
            };

            if (Race == null)
            {
                errorMessage = "Race is required";
                return false;
            };

            if (!ValidateAttribute(Strength))
            {
                errorMessage = $"Strength must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                return false;
            };
            if (!ValidateAttribute(Intelligence))
            {
                errorMessage = $"Intelligence must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                return false;
            };
            if (!ValidateAttribute(Agility))
            {
                errorMessage = $"Agility must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                return false;
            };
            if (!ValidateAttribute(Constitution))
            {
                errorMessage = $"Constitution must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                return false;
            };
            if (!ValidateAttribute(Charisma))
            {
                errorMessage = $"Charisma must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                return false;
            };

            errorMessage = null;
            return true;            
        }

        #region Private Members
                
        private bool ValidateAttribute ( int value ) => (value >= MinimumAttributeValue) && (value <= MaximumAttributeValue);
        
        
        private string _name, _bio;

        #endregion

        /// <summary>Represent the player attributes</summary>
        /// <returns>Returns character</returns>
        public Character repPlayer ()
        {
            var character = new Character();
            character.Name = Name;
            character.Profession = Profession;
            character.Race = Race;
            character.Biography = Biography;
            character.Strength = Strength;
            character.Intelligence = Intelligence;
            character.Agility = Agility;
            character.Constitution = Constitution;
            character.Charisma = Charisma;

            return character;
        }
    }
}
