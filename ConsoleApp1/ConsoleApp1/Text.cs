using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Text
    {
        public static void Print(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
        }

        public void TextPrecursor(int textType, bool createOnNewLine) // may add a colour tag if i feel the need to later on
        {
            if (createOnNewLine == true)
            {
                Print("\n", 0);
            }
            if (textType == 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Print("NULL>     ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (textType == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print(">>>>>     ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            else if (textType == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Print(" * >>      ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            else if (textType == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Print("?????     ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            else if (textType == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print("*****     ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            else if (textType == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print("< i >     ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            else if (textType == 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print("< ! >     ", 0);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Print("ERROR     ", 0);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }




            // textType Key:
            // 0 = Null
            // 1 = Narrative
            // 2 = Action
            // 3 = Mystery
            // 4 = Battle
            // 5 = Description






        }
    }
}
