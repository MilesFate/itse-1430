/*
 * File Header
 * Luisalberto Castaneda
 * ITSE 1430 Fall 2021
 */
using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            static void DemoLogicalOperators()
            {
                // Logical AND - true if both are true
                // Logical OR - true if either is true
                //     X    Y    &&   ||
                //  -----------------------
                //     F    F    F     F
                //     F    T    F     T
                //     T    F    F     T
                //     T    T    T     T
                //

                // NOT 
                //     F  !F  = T
                //     T  !T  = F

            }

            static void DemoRelationalOperators()
            {
                int x = 10, y = 20;

                bool isLessThen = x < y;
                bool isLessThenOrEqualTo = x <= y;

                bool isGreaterThen = x > y;
                bool isLessGreaterOrEqualTo = x >= y;

                bool isEqual = x == y;
                bool isNotEqual = x != y;

            }

            static void DemoCombinationOperators ()
            {
                // works for more than just arithmetic
                int x = 10;

                x += 10;    // x = x + 10
                x-= 20;     // x = x - 20
                x *= 3;     // x = x * 3
                x /= 5;     // x = x / 5
                x %= 2;     // x = x % 2
            }

            static void DemoPrefixPostfixOperators ()
            {
                int x = 10, y;

                //Prefix increment
                //   1. Take current value of X and increment by 1
                //   2. Store new value back in X
                //   3. Expression value is current value of X
                y = ++x;  //x = 11, y = 11

                //Prefix decrement
                //   1. Take current value of X and decrement by 1
                //   2. Store new value back in X
                //   3. Expression value is current value of X
                y = --x;  //x = 10, y = 10

                //Postfix increment
                //   1. Store current value of X in Tmp
                //   2. Increment X by one and store back in X
                //   3. Expression value is Tmp (original value of X)
                y = x++;  //x = 11, y = 10

                //Postfix decrement
                //   1. Store current value of X in Tmp
                //   2. Decrement X by one and store back in X
                //   3. Expression value is Tmp (original value of X)
                y = x--;  //x = 10, y = 11
            }

            static void DemoAssignmentOperator ()
            {
                int x;
                int y;
                int z;

                x = 10;
                y = 10;
                z = 10;

                // left assoiciative (E1 op E2) => E1, E2, op
                // right associative operator (E1 op E2) => E2, E1, op

                x = y = z = 20; // x = (y = (z = 20));
            }

            static void ConditionalOperator ()
            {
                int grade = 70;
                string passStatus;

                if (grade < 60)
                    passStatus = "Not Passing";
                else
                    passStatus = "Passing";

                // Terninary - 3 operands
                // E(bool) ? E(true) : E(false)

                string passStatus2 = (grade > 60) ? "Not Passing" : "Passing";
            }

            static void DemoString ()
            {
                string firstName = "Bob";

                // relationals work, case sensitive
                bool isbob = firstName == "Bob";

                // String Literals
                string literal1 = "Hello World";

                // Escape Sequence - \? only work in literals
                // \n => newline
                // \t => horizontal tab
                // \\ => slash
                // \" => double quote
                // \' character literal, single quote
                literal1 = "Hello \nWorld";
                string quoteString = "Hello \"Bob\"";
                
                string filePath = "C:\\windows\\system32\\tasks";
                string verbatimString = @"C:\windows\system32\tasks";

                // String length .Length => how many Characters
                int length = literal1.Length;

                // Empty String
                string emptyString = ""; // length = 0
                string emptyString2 = String.Empty; // length = 0
                bool areEmptyStringsEqual = String.Empty == ""; // True

                // null != empty string
                // Default value for strings is null
                string nullString = null;
                bool areEqualNull = "" == null; // False

                // string is the universal type in c#
                // all expressions are convertable to string using .ToString
                string asString = length.ToString(); // legnth as a string
                asString = 10.ToString(); // "10"
                asString = areEqualNull.ToString(); // "False"

                // Comparison
                string value1 = "Hello", value2 = "hello";
                bool areEqual = value1 == value2;
                bool compareCaseSensitive = String.Compare(value1, value2) == 0;
                bool compareCaseInsensitive = String.Compare(value1, value2, true) == 0; // Preferred

                compareCaseSensitive = value1.CompareTo(value2) == 0; // works but not safe

                string lowerValue1 = value1.ToLower();
                string upperValue1 =  value2.ToUpper();
                compareCaseInsensitive = value1.ToUpper() == value2.ToUpper();

                // Concatenation : first last year
                int year = 2021;
                firstName = "Rat";
                string lastName = "Irl";
                string name = firstName + " " + lastName + " " + year; // Rat Irl
                name = string.Concat(firstName," ",lastName, " ",year);  // for larger # of strings
                
                var builder = new StringBuilder();
                builder.Append(firstName);
                builder.Append(" ");
                builder.Append(lastName);
                builder.Append(" ");
                builder.Append(year);
                name = builder.ToString();

                name = String.Join(" ", firstName, lastName, year);

                // Misc
                bool startWithB = name.StartsWith("B");
                startWithB = name.StartsWith("B",StringComparison.CurrentCultureIgnoreCase);

                bool endsWith9 = name.EndsWith("9");
                endsWith9 = name.EndsWith("9", StringComparison.CurrentCultureIgnoreCase);

                // removes leading and trailing whitespace
                string normalizedName = name.Trim();
                //name.TrimStart().TrimEnd();

                // Some useful stuff
                //name.Substring(startIndex); // gets a subset of string
                //name.IndexOf(character); // finds a character

                name = name.PadLeft(50); // will add enough spaces on left to make string legnth 50
                name = name.PadRight(50); // will add enough spaces on right to make string legnth 50

                // empty string checking
                bool isempty;
                isempty = name == ""; // not always going to work correctly
                isempty = name.Length == 0; //will crash if null

                //handle null
                isempty = (name != null) ? name == "" : true;
                isempty = name == null || name == "";
                isempty = (name != null) ? name.Length == 0 : true;
                isempty = String.IsNullOrEmpty(name); // preferred


                // Formatting - Hello first last , the year is year
                name  = "Hello "+firstName + " "+ lastName+", the year is "+ year +".";
                name = String.Format("Hello {0} {1} , the year is {2}.",firstName,lastName,year);
                Console.WriteLine("Hello {0} {1} , the year is {2}.", firstName, lastName, year);

                decimal price = 8.75M;
                string priceString = price.ToString(); // 8.750000
                priceString = price.ToString("C"); // money 8.75
                priceString = price.ToString("N6:N2"); // 8.7500
                priceString = String.Format("{0:c}", price);

                // String interpolation - way to go (because name is fancy)
                name = $"Hello {firstName} {lastName} , the year is {year:0000}.";

            }
        } // do not pass go
    }
}
