using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CursorTest
    {
        public static void Cursor()
        {   // I stole this entire script below from the internet lmao
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.CursorVisible = false;
            Console.Write('*');

            var random = new Random();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (Console.CursorTop > 0)
                            {
                                Console.SetCursorPosition(Console.CursorLeft - 1,
                                    Console.CursorTop - 1);
                                Console.Write('*');
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (Console.CursorTop < Console.BufferHeight)
                            {
                                Console.SetCursorPosition(Console.CursorLeft - 1,
                                    Console.CursorTop + 1);
                                Console.Write('*');
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (Console.CursorLeft > 1)
                            {
                                Console.SetCursorPosition(Console.CursorLeft - 2,
                                    Console.CursorTop);
                                Console.Write('*');
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (Console.CursorLeft < Console.WindowWidth - 1)
                            {
                                Console.Write('*');
                            }
                            break;
                    }
                }

                // This method should be called on every iteration, 
                // and the iterations should not wait for a key to be pressed
                // Instead of Frame.Update(), change the foreground color every three seconds  
                if (DateTime.Now.Second % 3 == 0)
                    Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
            }
        }
    }
}
