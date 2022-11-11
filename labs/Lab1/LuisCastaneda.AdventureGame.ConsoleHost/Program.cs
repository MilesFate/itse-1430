/* Luisalberto Castaneda
 * ITSE 1430
 * Adventurre Game
 * Fall 2020
 */

using System;

namespace LuisCastaneda.AdventureGame.ConsoleHost
{
    internal class Program
    {
        static string s_direction;        
        public static int s_roomNumber = 5;

        private static void Main()
        {
            introduction();
            var exit = false;
            do
            {
                var input = promptUserInput("What will you do? ").ToUpper();
                switch(input)
                {
                    case "MOVE":
                    {
                        s_roomNumber = DirectionAcquisition("Which direction do you want to move? ");
                        SetRoom(s_roomNumber);
                        break;
                    }
                    case "EXAMINE": SetRoom(s_roomNumber); break;
                    case "QUIT": exit = HandleExit(); break;
                    default : HandleError("invalid input"); break;
                }
            } while (!exit);
        }

        private static void SetRoom ( int s_roomNumber )
        {
            switch (s_roomNumber)
            {
                case 1: room1(); break;
                case 2: room2(); break;
                case 3: room3(); break;
                case 4: room4(); break;
                case 5: room5(); break;
                case 6: room6(); break;
                case 7: room7(); break;
                case 8: room8(); break;
                case 9: room9(); break;
            };
        }

        private static string promptUserInput ( string message )
        {
            Console.Write(message);
            var command = Console.ReadLine().Trim().ToUpper();
            while (command == "HELP")
            {
                help();
                Console.Write(message);
                command = Console.ReadLine().Trim();
            }
            return command;
        }

        private static bool HandleExit () => ReadBoolean("Are you sure you want to quit (Y/N)?");

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message);
            do
            {
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y)
                    return true;
                else if (input.Key == ConsoleKey.N)
                    Console.WriteLine("");
                    return false;

            } while (true);
        }

        private static int DirectionAcquisition ( string message )
        {
            
            do
            {
                Console.Write(message);
                s_direction = Console.ReadLine().Trim().ToUpper();

                switch(s_direction)
                {
                    case "UP" : return HandleUp();
                    case "DOWN": return HandleDown();
                    case "LEFT": return HandleLeft();
                    case "RIGHT": return HandleRight();
                    default : HandleError("Invalid Input"); break;
                }
            } while (true);
            
        }

        private static int HandleUp ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 4 : return s_roomNumber = 1;
                    case 5 : return s_roomNumber = 2;
                    case 6 : return s_roomNumber = 3;
                    case 7 : return s_roomNumber = 4;
                    case 8 : return s_roomNumber = 5;
                    case 9 : return s_roomNumber = 6;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static int HandleDown ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 1: return s_roomNumber = 4;
                    case 2: return s_roomNumber = 5;
                    case 3: return s_roomNumber = 6;
                    case 4: return s_roomNumber = 7;
                    case 5: return s_roomNumber = 8;
                    case 6: return s_roomNumber = 9;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static int HandleLeft ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 2: return s_roomNumber = 1;
                    case 3: return s_roomNumber = 2;
                    case 5: return s_roomNumber = 4;
                    case 6: return s_roomNumber = 5;
                    case 8: return s_roomNumber = 7;
                    case 9: return s_roomNumber = 8;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static int HandleRight ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 1: return s_roomNumber = 2;
                    case 2: return s_roomNumber = 3;
                    case 4: return s_roomNumber = 5;
                    case 5: return s_roomNumber = 6;
                    case 7: return s_roomNumber = 8;
                    case 8: return s_roomNumber = 9;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static void HandleError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void introduction ()
        {
            Console.WriteLine("ITSE 1430, Luisalberto Castaneda, Adventure Game, Fall 2020");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("As you wake from from a deep slumber you find that you are in a strange room. ");
            Console.Write("Getting off the table you were lying on you keep an eye on the shadows in the room, noticing that they seem... strange. ");
            Console.Write("Exting from this room leads you to an ally more fit to called a slum then the marvel it was sold as. ");
            Console.Write("In this rundown crumbling ally you notice a clean, maintained door that seems more unnerving then your current state. ");
            Console.Write("Entering this door you find that it has swallowed you into an abyss. ");
            Console.WriteLine("Regaining sight, you scan the surroundings only to find that you are in a dim room with a door on each wall.");
            Console.ResetColor();
        }
        

        private static void room1 ()
        {
            Console.WriteLine("1");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("After going through the door you feel the atmosphere become more relaxed hearing Kazoo music, feeling like you can lower your guard. ");
            Console.Write("You approach a bar counter and are handed a water by the bar tender with him softly saying \"Water is the best drink you could offer someone.\". ");
            Console.Write("Looking around you see a man holding a sigh with \"IDK\" printed on it while he whispers \"schwelp\". ");
            Console.WriteLine("Knowing you need to find an exit, you reluctantly force yourself to leave this safehaven. ");
            Console.ResetColor();
        }

        private static void room2 ()
        {
            Console.WriteLine("2");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". ");
            Console.Write("Looking around it seems as you are in some kind of kids birthday party. ");
            Console.Write("The more you look the more try and remember if you had ever been there but nothing ever seems to fit, like it was a burning memory. ");
            Console.WriteLine("noticing the shadows in the room seem to be too big to fit in the room, you decide you should leave. ");
            Console.ResetColor();
        }

        private static void room3 ()
        {
            Console.WriteLine("3");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Stepping into the room you are met with the sand of a desert, the room seems so vast that you nearly miss the edges of the room. ");
            Console.Write("In the middle of this artificial landscape you see a statue hidden. ");
            Console.Write("On this statue is read \" Here lies Bright, the Ruler of Rulers.\". ");
            Console.WriteLine("Notcing the shadows in the room seem to be too big to fit in the room, you decide you should leave. ");
            Console.ResetColor();
        }

        private static void room4 ()
        {
            Console.WriteLine("4");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". ");
            Console.Write("Seeing the stage so empty made you think of the worlds cruelty, thinking that they deserve a performance of a lifetime. ");
            Console.Write("As the curtains raise you see that every seat is full, everyone waiting for an encore of the ages. ");
            Console.Write("After the possession of your body by the Virtuose, the sense of perfection fills your thoughts. ");
            Console.Write("The curtain lowers and you regain your senses feeling like you gave the audience what they came to see. ");
            Console.WriteLine("Feeling there is nothing more to do, you feel as if its time to go to another room. ");
            Console.ResetColor();
        }

        private static void room5 ()
        {
            Console.WriteLine("5");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Upon further examnation of the room it seems as though many have passed into this room before your arrival.");
            Console.Write("With the walls looking centries old in some spots and in other seeming to be from a time yet to come it is clear that this new environment holds many secrets. ");
            Console.Write("The flicker of the candle catches the eye making you wonder \"Who lit the candle?\". ");
            Console.WriteLine("Regardless of the candles presence, the shadows seem to be too big to fit in the room, they seem to be growing the longer you stay. ");
            Console.ResetColor();
        }
        
        private static void room6 ()
        {
            Console.WriteLine("6");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". ");
            Console.Write("With the room being lit up by purple lights it gave off a certain feeling. ");
            Console.Write("You are then approached by an indian man who then spends hours telling you why should set up a virtual machine for ever website you visit. ");
            Console.WriteLine("Feeling there is nothing more to do, you feel as if its time to go to another room. ");
            Console.ResetColor();
        }

        private static void room7 ()
        {
            Console.WriteLine("7");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Entering the room you notice there are three doors, two are freely accessible while the third is blocked by a wall. ");
            Console.Write("Examining the wall you see it is made of pure diamond, you start to punch it to try and get passed it. ");
            Console.Write("After punching at the wall for a few hours you think to yourself \"it would take an eternity to get through this wall.\". ");
            Console.WriteLine("Noticing the shadows in the room seem to be too big to fit in the room, you decide you should leave. ");
            Console.ResetColor();
        }

        private static void room8 ()
        {
            Console.WriteLine("8");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". ");
            Console.Write(" \"Your eyes deceive you\", ");
            Console.Write(" \"An illusion fools you all\", ");
            Console.WriteLine(" \"Was just a mirror\" ");
            Console.WriteLine("Feeling there is nothing more to do, you feel as if its time to go to another room. ");
            Console.ResetColor();
        }

        private static void room9 ()
        {
            Console.WriteLine("9");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Upon entering you notice an imideate change. ");
            Console.Write("It's as if time and space have both stop existing the way you have come to understand them. ");
            Console.Write("After regaining your composure after what was the greatest shift a body can have, you notice a man leaning against the wall. ");
            Console.WriteLine("Approaching the man he smiles and says \"What's up broski, I'm Vlad and this is my time!\", you awkwardly wave and look for an exit. ");
            Console.ResetColor();
        }

        private static void help ()
        {
            Console.WriteLine("Move    :: Right | Left | Up | Down");
            Console.WriteLine("Examine :: ReShows what room your in");
            Console.WriteLine("Help    :: Get Help");
            Console.WriteLine("Quit    :: Quit the Program");
        }
    }
}
