using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GameText
    {
        public static void Print(string text1 = null, int speed1 = 0, string text2 = null, int speed2 = 0, string text3 = null, int speed3 = 0, string text4 = null, int speed4 = 0, string text5 = null, int speed5 = 0, string text6 = null, int speed6 = 0, string text7 = null, int speed7 = 0, string text8 = null, int speed8 = 0, string text9 = null, int speed9 = 0, bool Precursor = true, int PrecursorType = 1)
        {
            string[] text = { text1, text2, text3, text4, text5, text6, text7, text8, text9 };
            int[] speed = { speed1, speed2, speed3, speed4, speed5, speed6, speed7, speed8, speed9 };
            for (int i = 0; i < 7; i++)
            {
                //if (Precursor == true)
                //{
                //    GameText.Precursor(1);
                //}
                if (text[i] == null)
                    break;
                else {
                    foreach (char c in text[i])
                    {
                        Console.Write(c);
                        Thread.Sleep(speed[i]);

                        if (c.Equals('\n') )
                        {
                            GameText.Precursor(1);
                        }
                        else {  }
                        
                    }
                }
            }
        }

        public static void Precursor(int textType, bool createOnNewLine = false) // may add a colour tag if i feel the need to later on
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            if (createOnNewLine == true)
            {
                Console.Write("\n");
            }
            if (textType == 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("NULL>     |");
                Console.ForegroundColor = originalColor;
            }
            else if (textType == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("          |");
                Console.ForegroundColor = originalColor;
            }

            else if (textType == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" * >>      ");
                Console.ForegroundColor = originalColor;
            }

            else if (textType == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("?????     ");
                Console.ForegroundColor = originalColor;
            }

            else if (textType == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*****     ");
                Console.ForegroundColor = originalColor;
            }

            else if (textType == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("< i >     ");
                Console.ForegroundColor = originalColor;
            }

            else if (textType == 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("< ! >     ");
                Console.ForegroundColor = originalColor;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("ERROR     ");
                Console.ForegroundColor = originalColor;
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
