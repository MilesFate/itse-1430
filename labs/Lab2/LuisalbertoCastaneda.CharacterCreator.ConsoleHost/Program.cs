/*
 * Luisalberto Castaneda
 * ITSE-1430
 * Lab2 - Character Creator
 */
using System;

namespace LuisalbertoCastaneda.CharacterCreator.ConsoleHost
{
    class Program
    {
        static void Main ()
        {
            Console.WriteLine("ITSE 1430 Character Creator");
            Console.WriteLine("Luisalberto Castaneda ITSE-1430 Fall 2021");
            var s1 = "";
            Console.WriteLine(s1.PadLeft(50, '-'));
            var exit = false;

            do
            {
                DisplayMainMenu();
                int choice = GetIntInput("Enter your choice: ");
                switch (choice)
                {
                    case 0 : exit = HandleConfirmation("Are you sure you want to quit? (Y/N)"); break;
                    case 1 : AddCharacter(); break;
                    case 2 : ViewCharacter(); break;
                    case 3 : EditCharacter(); break;
                    case 4 : DeleteCharacter(); break;
                    default : HandleError("Value not on the menu."); break;
                }
            } while (!exit);
        }

        static Character s_character;

        static void DisplayMainMenu ()
        {
            Console.WriteLine("0 : Quit");
            Console.WriteLine("1 : Add Character");
            Console.WriteLine("2 : View Character");
            Console.WriteLine("3 : Edit Character");
            Console.WriteLine("4 : Delete Character");
        }

        static void AddCharacter ()
        {
            Character newCharacter = new Character();
            newCharacter.Name = GetStringInput("Enter the name for the new character: ", true);
            newCharacter.Profession = GetProfession();
            newCharacter.Race = GetRace();
            newCharacter.Biography = GetStringInput("Enter the biography for the new character (optional): ", false);
            newCharacter.Strength = GetCharacterAttributeNumber("Enter the character's strength: ");
            newCharacter.Intelligence = GetCharacterAttributeNumber("Enter the character's intelligence: ");
            newCharacter.Agility = GetCharacterAttributeNumber("Enter the character's agility: ");
            newCharacter.Constitution = GetCharacterAttributeNumber("Enter the character's constitution: ");
            newCharacter.Charisma = GetCharacterAttributeNumber("Enter the character's charisma: ");
            s_character = newCharacter;
        }

        static void ViewCharacter ()
        {
            if (s_character != null)
            {
                Console.WriteLine("---- Character Information ----");
                Console.WriteLine();
                Console.WriteLine($"Name: {s_character.Name}");
                Console.WriteLine($"Profession: {s_character.Profession}");
                Console.WriteLine($"Race: {s_character.Race}");
                Console.WriteLine($"Biography: {s_character.Biography}");
                Console.WriteLine($"Strength: {s_character.Strength}");
                Console.WriteLine($"Intelligence: {s_character.Intelligence}");
                Console.WriteLine($"Agility: {s_character.Agility}");
                Console.WriteLine($"Constitution: {s_character.Constitution}");
                Console.WriteLine($"Charisma: {s_character.Charisma}");
                Console.WriteLine();
            } else
                HandleError("There is no character created.");
        }

        static void EditCharacter ()
        {
            if (s_character == null)
                AddCharacter();

            Console.WriteLine("0 - Exit Edit | 1 - Name | 2 - Profession | 3 - Race | 4 - Biography");
            Console.WriteLine("5 - Strenth | 6 - Intelligence | 7 - Agility | 8 - Constitution | 9 - Charisma");
            var input = GetIntInput("What do you wish to change? ");                
            switch (input)
            {
                case 0: ViewCharacter(); break;
                case 1: s_character.Name = GetStringInput("Enter the new name for the character: ", true); break;
                case 2: s_character.Profession = GetProfession(); break;
                case 3: s_character.Race = GetRace(); break;
                case 4: s_character.Biography = GetStringInput("Enter the new biography for the character: ", false); break;
                case 5: s_character.Strength = GetIntInput("Enter the character's strength: "); break;
                case 6: s_character.Intelligence = GetIntInput("Enter the character's intelligence: "); break;
                case 7: s_character.Agility = GetIntInput("Enter the character's agility: "); break;
                case 8: s_character.Constitution = GetIntInput("Enter the character's constitution: "); break;
                case 9: s_character.Charisma = GetIntInput("Enter the character's charisma: "); break;
            }

        }

        static void DeleteCharacter ()
        {
            if (s_character != null)
            {
                if (HandleConfirmation("Are you sure you want to delete the character? (Y/N)"))
                {
                    s_character = null;
                    Console.WriteLine("Character deleted.");
                } else
                    Console.WriteLine("Character not deleted.");
            } else
                HandleError("There is no character to delete.");
        }

        static string GetProfession ()
        {
            do
            {
                string input = GetStringInput("Enter the profession for the character: ", true);

                if (input == "SNIPER" || input == "HUNTER" || input == "ASSASSIN" || input == "MAGE" || input == "CHAPO")
                    return input;
                else
                    HandleError("You Must Input : Sniper, Hunter, Assassin, Mage, Chapo");

            } while (true);
        }

        static string GetRace ()
        {
            do
            {
                string input = GetStringInput("Enter the race for the character: ", true);

                if (input == "ZENO" || input == "HUMAN" || input == "RACCOON" || input == "ROBOT" || input == "MONSTER")
                    return input;
                else
                    HandleError("You Must Input : Zeno, Human, Raccoon, Robot, Monster");

            } while (true);
        }

        static string GetStringInput ( string message, bool required )
        {
            do
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim().ToUpper();
                if (!String.IsNullOrEmpty(input) || !required)
                    return input;
                else
                    HandleError("Input is required.");

            } while (true);
        }

        static int GetIntInput ( string message )
        {
            do
            {
                Console.Write(message);
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var result))
                    return result;
                HandleError("Invalid Input");

            } while (true);
        }

        static int GetCharacterAttributeNumber ( string message )
        {
            do
            {
                int value = GetIntInput(message);

                if (value <= Character.maximumValue && value >= Character.minimumValue)
                    return value;
                else
                    HandleError("Value not in range. (1 - 100)");

            } while (true);
        }

        static bool HandleConfirmation ( string message )
        {
            do
            {
                Console.WriteLine(message);
                ConsoleKeyInfo answer = Console.ReadKey(true);
                switch (answer.Key)
                {
                    case ConsoleKey.Y: return true;
                    case ConsoleKey.N: return false;
                    default: HandleError("Invalid input."); break;
                }

            } while (true);
        }


        static void HandleError ( string Message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
