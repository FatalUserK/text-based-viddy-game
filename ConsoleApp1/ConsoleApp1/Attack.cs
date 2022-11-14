using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Attack
    {
        public static void SlashAttack(int BaseDmg, int AdditionalDmg, int TimeFrameS)
        {
            DateTime Start = DateTime.UtcNow;           // https://stackoverflow.com/questions/27359345/how-to-check-if-specific-time-has-passed
            TimeSpan Length = TimeSpan.FromSeconds(TimeFrameS);
            int count = 0;
            while (DateTime.UtcNow - Start < Length)
            {
                if (Console.KeyAvailable)                    // https://stackoverflow.com/questions/63818349/c-sharp-net-console-application-getting-keyboard-input
                {
                    var key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.Spacebar:
                            count++;
                            break;
                    }
                }
            }
        }
    }
}
