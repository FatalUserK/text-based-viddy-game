using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;
using System.Drawing;
using System.Formats.Asn1;
//using System.Media.SystemSounds;

class Program
{
    static int universaltemp1 = 0;
    public static void Main(string[] args)
    {
        // Wow, look! What a cool game...
        //
        // I wonder
        //          if anyone's
        //                      going to
        //                               make it
        //                                       :)
        Console.ForegroundColor = ConsoleColor.Cyan;

        PrintLong("Wow,", 1, " ", 700, "look!", 1, " ", 1300, "What a cool gam", 1, "e", 1500, "...", 900);
        Thread.Sleep(2000);


        //////////////////////////////////////////// TESTING SPACE START ////////////////////////////////////


        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
        //player.Play();







//////////////////////////////////////////// TESTING SPACE END ////////////////////////////////////


        // "Wow, look! What a cool game" is a meta reference showing that this game is likely to be less formal with its humor and story since its acknowledging itself as a game
        Console.ForegroundColor = ConsoleColor.Green;
        Print("\n\nI wonder\n", 15);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Print("         ", 0);
        Print("if anyone's\n", 15);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Red;
        Print("                     ", 0);
        Print("going to\n", 15);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Print("                              ", 0);
        Print("make it\n", 15);
        Thread.Sleep(800);
        Console.ForegroundColor = ConsoleColor.Blue;
        Print("                                      ", 0);
        Print(":)\n", 5);
        Thread.Sleep(1500);

        // ^ this is initially just a funny little intro i made for fun but i could give it some meaning later on or in a later iteration of this project, such as the game ending with everyone dying, showing that nobody is "going to make it"



        // holds off on running the scripts that put the game together until the player enters an input, this act as a gatekeeper as it were but will also act as the input for the main antagonist.
        // The User is probably unaware of this and will likely bring some sort of gratification knowing this choice had some sort of payoff in the long run,
        // This could also lead to some comedic moments later on deciding on the input the user decided on
        Print("\n\n\n\n[Type anything to ", 10);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Print("START", 10);
        Console.ForegroundColor = ConsoleColor.Blue;
        Print("]\n\n", 10);


        // randomise list set up in the event the user does not enter inputs when required

        // The Names here are chosen either to be funny or punish the player in some way, however some "normal" names were thrown in to even out the experience and to make the other ones feel more special, a sort of filler

        //string[] randStartInput = { "This Integer Is Impossible To Have Appear!", "Consequence of Sloth", "Big Meanie", "THIS! USER! IS! LAZY!!!", "lmaooooo", "Antagonist", "Reverend of Sloth", "START!", "Maybe you should have inputted something for the first input...", "ERROR", "INPUT", "INPUT_UNREGISTERED", "An unexpected error has occurred in pulling \"string(startInput)\", please refer to https://dotnet.microsoft.com/en-us/platform/support for more information.", "Advent of Hell", "(insert edgy title/name here)", "The One who Wins", "The Great Adversary", "Xx_Samurai_R_C0ol_xX", "sans" };
        //List<string> randStartInputList = new List<string>(randStartInput);

        // god im going to lose track of all these comments, arent i?
        string startInput = "";

        Random rnd = new Random();
        int randNumber = rnd.Next(1, 19); // apparently i cant remove this, this single line of code holds the entire script together (shut up yes i know i can just remove it and fix it easily but shush)


        while (startInput == "")
        {
            //Console.WriteLine(randStartInputList[randNumber]);
            Console.ForegroundColor = ConsoleColor.White;
            startInput = Console.ReadLine();
            Thread.Sleep(450);



            if (startInput == "debug")
            {
                TextPrecursor(0, true);
                Print("Empty", 20);
                TextPrecursor(1, true);
                Print("Narrative", 20);
                TextPrecursor(2, true);
                Print("Action", 20);
                TextPrecursor(3, true);
                Print("Mystery", 20);
                TextPrecursor(4, true);
                Print("Description", 20);
                TextPrecursor(5, true);
                Print("Null", 20);
                TextPrecursor(6, true);
                Print("Null", 20);
                TextPrecursor(7, true);
                Print("Null", 20);
                TextPrecursor(8, true);
                Print("Null", 20);
                TextPrecursor(9, true);
                Print("Null", 20);

                randNumber = rnd.Next(0, 1000);

                Print("\n\n0-1000: " + randNumber, 20);
                Print("3 2 1 ", 500);
                Print("GO!", 0);

                DateTime startTimer = DateTime.UtcNow;           // https://stackoverflow.com/questions/27359345/how-to-check-if-specific-time-has-passed
                TimeSpan timerLength = TimeSpan.FromSeconds(3);
                int count = 0;
                while (DateTime.UtcNow - startTimer < timerLength)
                {
                    if (Console.KeyAvailable)                    // https://stackoverflow.com/questions/63818349/c-sharp-net-console-application-getting-keyboard-input
                    {
                        var key = Console.ReadKey(true);

                        switch (key.Key)
                        {
                            case ConsoleKey.Spacebar:
                                count ++;
                                break;
                        }
                    }
                }
                Print("You pressed the Spacebar " + count + " times!", 20);

                Print("\n\nRunning Text Delay Test in ", 20);
                Print("3 2 1\n", 500);
                PrintLong("  <<<<10>>>>  ", 10, "  <<<<50>>>>", 50, "  <<<<100>>>>  ", 100, "  <<<<500>>>>  ", 500, "  <<<<1000>>>> ", 1000, "  <<<<5000>>>>  ", 5000, "  <<<<10000>>>>  ", 10000);

                startInput = "";
            }


            else if (startInput == "math")
            {
                ascii(1, 10, 10);


                universaltemp1 == (universaltemp1.ToString)
                universaltemp1.ToString = Console.ReadLine();
                String.ToInt32 universaltemp1;



                startInput = "";
            }

            else if (startInput == "hero")
            {
                string[] heroes = { "Superman", "Batman", "Thor", "God", "Ironman" };
                List<string> heroesList = new List<string>(heroes);
                int heroValidInput = 0;
                int heroInputFailure = 0;
                string hero = "";
                while (heroValidInput == 0)
                {
                    hero = "";
                    Print("\n\nSuperman, Batman, Thor, God, Ironman:\n", 20);
                    hero = Console.ReadLine();
                    if (heroesList.Contains(hero)) { heroValidInput++; }
                    else if (hero.Length < 1) { Print("\nPlease give an input.", 20); }
                    else if (heroInputFailure <= 5) { Print("\nPlease give a valid input.", 20); heroInputFailure++; }
                    else { Print("\nPlease give a valid input, note that the input is Case-sensitive", 20); }
                }
                Print("Thank you for your input...\n", 20);
                if (hero == "Superman") { Print("He can do literally anything but is stupid", 20); }
                else if (hero == "Batman") { Print("He's angsty and rich", 20); }
                else if (hero == "Thor") { Print("Theoretically a God of Thunder, really just some overweight Fortnite player", 20); }
                else if (hero == "God") { Print("Basically Superman but better", 20); }
                else if (hero == "Ironman") { Print("Weak as shit but rich and smart as hell", 20); }
                else { Print("WHAT THE FUCK", 60); };
                startInput = "";
            }
            if (startInput == "CursorTest") { CursorTest(); }




            else if (startInput == "fight")
            {

                int battleEnd = 0;
                int MonsterHealth = 30;
                int PlayerHealth = 20;
                while (battleEnd == 0)
                {
                    Print("\n\nA monster appears!\n", 30);
                    Print("Monster Health: " + MonsterHealth + "\n", 5);
                    Print("Player Health: " + PlayerHealth + "\n", 5);
                    randNumber = rnd.Next(1, 3);
                    switch (randNumber)
                    {
                        case 1:
                            Print("Monster gets up close!", 30);
                            break;
                        case 2:
                            Print("Monster Attempts to Flee", 30);
                            break;
                        case 3:
                            Print("Monster prepares a healing spell", 30);
                            break;
                    }
                    Print("\n\n What will you do?\n  Punch [Z]\n  Shoot [X]\n Block [C]\n\n", 20);

                    bool PlayerTurn = true;

                    while (PlayerTurn == true)
                    {
                        if (Console.KeyAvailable)
                        {
                            var key = Console.ReadKey(true);

                            switch (key.Key)
                            {
                                case ConsoleKey.Z:
                                    PlayerTurn = false;
                                    break;
                                case ConsoleKey.X:
                                    PlayerTurn = false;
                                    randNumber += 3;
                                    break;
                                case ConsoleKey.C:
                                    PlayerTurn = false;
                                    randNumber += 6;
                                    break;

                            }
                        }
                    }

                    switch (randNumber)
                    {
                        case 1:
                            Print("Monster successfully blocks and counters dealing 5 Damage!\n", 30);
                            PlayerHealth -= 5;
                            break;
                        case 2:
                            Print("Monster escapes you successfully, Battle End!", 30);
                            battleEnd = 3;
                            break;
                        case 3:
                            Print("Monster is caught off guard and takes 10 Damage!", 30);
                            MonsterHealth -= 10;
                            break;
                        case 4:
                            Print("Monster is too close! Monster deals 10 Damage", 30);
                            PlayerHealth -= 10;
                            break;
                        case 5:
                            Print("Player successfully hits Monster, Monster takes 10 Damage!", 30);
                            MonsterHealth -= 10;
                            break;
                        case 6:
                            Print("Monster sees Player readying their bow and succesfully dodges!", 30);
                            break;
                        case 7:
                            Print("Monster attempts to attack but is blocked, Player counters and deals 5 Damage!", 30);
                            break;
                        case 8:
                            Print("Monster successfully flees as Player does nothing, Battle End!", 30);
                            battleEnd = 3;
                            break;
                        case 9:
                            Print("Monster Successfully Heals 5 HP!", 30);
                            MonsterHealth += 5;
                            break;
                    }

                    if (MonsterHealth < 1) { battleEnd = 1; }
                    else if (PlayerHealth < 1) { battleEnd = 2; }
                    else { battleEnd = 0; };

                }
                switch (battleEnd)
                    {
                    case 1:
                        Print("\n\nPlayer Successfully Won with " + PlayerHealth + " HP!\n\n", 50);
                        break;
                    case 2:
                        Print("\n\nPlayer Died! Monster survived with " + MonsterHealth + " HP!\n\n", 50);
                        break;
                    case 3:
                        Print("\n\nMonster escaped the Player successfully and went on to murder 37 people, Player was then tried for their crimes of failing to subjugate the monster and was sentenced to public execution, along with all those related and associated to them.\n\n", 50);
                        break;


                };



                    DateTime startTimer = DateTime.UtcNow;           // https://stackoverflow.com/questions/27359345/how-to-check-if-specific-time-has-passed
                TimeSpan timerLength = TimeSpan.FromSeconds(3);
                int count = 0;
                while (DateTime.UtcNow - startTimer < timerLength)
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







            if (string.IsNullOrEmpty(startInput))
            {
                //startInput = (randStartInputList[randNumber]);
                Console.ForegroundColor = ConsoleColor.White;
                Print("\nFALSE POSITIVE DETECTED,", 20);
                Thread.Sleep(500);
                Print(" RETURNING TO DORMANT STATE", 20);
                Thread.Sleep(1200);
                Console.ForegroundColor = ConsoleColor.Blue;
                Print("\n\n\n\n[Type anything to ", 10);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Print("START", 10);
                Console.ForegroundColor = ConsoleColor.Blue;
                Print("]\n", 10);

            }


        }



        // runs various scripts that will help optimise things later on

        string playerName = "USER";
        string userInputEcho = playerName + " has made the input: ";
        startInput = "[" + startInput + "]";

        Console.ForegroundColor = ConsoleColor.Blue;

        // Print 
        Print("\n" + userInputEcho, 0);
        Console.ForegroundColor = ConsoleColor.White;
        Print(startInput, 0);
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Blue;
        Print("...", 800);
        Console.WriteLine();



        Thread.Sleep(1400);
        Console.ForegroundColor = ConsoleColor.Red;

        Print("\n\nWARNING! USER INPUT DETECTED,", 2);
        Console.ForegroundColor = ConsoleColor.White;
        Thread.Sleep(600);
        Print(" REQUESTING FOR RESPONSE FROM UNIT 221B", 2);
        Thread.Sleep(400);
        Print("...", 400);

        Thread.Sleep(1500);

        Print("\n\nRESPONSE RECEIVED, INITIALISING OIS", 2);
        Thread.Sleep(600);
        Print("...", 600);


        Thread.Sleep(1500);



        Print("\n\n\nOperator Interaction System Initialised...\n\n", 10);

        Thread.Sleep(1200);
        Console.ForegroundColor = ConsoleColor.Gray;
        string textTemp = "Analysing Trace...\n";               // sets the text that will be sent
        foreach (char c in textTemp)                            // runs the script for every letter left in the designated string [textTemp]
        {
            randNumber = rnd.Next(5, 140);                      // picks a random number between 5 and 500
            Print(c.ToString(), 40);                    // sends the next letter from [textTemp] that hasnt already been sent and then make the thread sleep the by the amount designated by the random number above

                                                // previously replaced "randNumber" with "40"

        }                                  // TODO: SIMPLIFY THIS INTO A FUNCTION, HAVENT DONE THIS YET AS I ACTUALLY DONT NEED IT RN
        Thread.Sleep(2000); 

        textTemp = "Trace Discovered...\n";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(5, 140);
            Print(c.ToString(), 40);            // previously replaced "randNumber" with "40"


        }
        Thread.Sleep(2000);

        textTemp = "Locking onto Source...\n";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(5, 140);
            Print(c.ToString(), 40);            // previously replaced "randNumber" with "40"


        }
        Thread.Sleep(2000);
        textTemp = "Entity Located, sending EDCP";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(30, 250);
            Print(c.ToString(), 40);            // previously replaced "randNumber" with "40"


        }
        Print("...\n", 300);



        textTemp = "54686520  456e6420  6f662047  6f642077\n696c6c20  42656661  6c6c2075  7320416c\n6c0d0a41  73207765  2044616e  63652062\n65666f72  65206869  7320436f  72707365\n20696e20  74686520  48616c6c  206f6620\n54687261  6c6c0d0a  42652073  74696c6c\n2c20616e  64206769  76652075  70204574\n65726e61  6c205265  73740d0a  4173206f\n75722044  61726b20  54686f75  67687473\n20626567  696e2074  6f204665  7374\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";

        Thread.Sleep(2000);

        int startIndex = 0;
        int length = 39;
        int tempCount = 0;

        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = 0; i < 5; i++)
        {
            String substring = textTemp.Substring(startIndex, length);
            Print(substring, 0);
            tempCount = (tempCount + 1);
            startIndex = startIndex + 39;
            Thread.Sleep(30);
        }

        Console.ForegroundColor = ConsoleColor.White;
        Print("INITIATING ", 1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Print("PACIFIER PROTOCOL", 1);

        Print("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n", 1);

        ascii(2, 5, 0);

        Console.ForegroundColor = ConsoleColor.White;

        Print("Welcome,", 13);
        Thread.Sleep(800);
        PrintLong(" Brave,", 13, " ", 13, "New", 13, " Adventurer,", 13, " ", 1100, "to the land of ", 13, "", 0);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Print("[RPG SIMULATOR]", 70);
        Console.ForegroundColor = ConsoleColor.White;
        Print("!\n\n", 10);

        Thread.Sleep(1500);




        // Picking the player's name

        bool userIsUncooperative = true;
        Print("Tell me, young lad,", 13);
        Thread.Sleep(1100);
        Print(" who is this legend about?\n", 43);

        Console.Write("Your name: ");
        playerName = Console.ReadLine();

        playerName = "[" + playerName + "]";


        Print("\n" + playerName + ",", 70);
        Thread.Sleep(650);
        Print(" huh?\n\n", 13);
        Thread.Sleep(1300);
        if (playerName == "[]") 
        {
            Print("Well I suppose if you don't want to answer,", 13);
            Thread.Sleep(800);
            Print(" it can't be helped.\n", 13);
            Thread.Sleep(1600);
            Print("However you still need a name,", 23);
            Thread.Sleep(600);
            Print(" I'll have to call you something!\n\n", 18);
            Thread.Sleep(1800);


            string[] randPlayerNames = { "Good Luck Getting This One!", "The Great Saviour", "Butter", "Harry", "The One who Wins", "Probably God", "ERROR IS YOU!", "A Fatal Error HASNT Occurred!", ":)", "Demon Slaughterer", "Devout One", "Apostle of God", "Pawn of a Higher Being", "There are strings on me!", "Distraction", "You", "Cannot", "Escape", "An Actor of God", "Puppet Boy" };
            List<string> randPlayerNamesList = new List<string>(randPlayerNames);
            randNumber = rnd.Next(1, 20);
            playerName = (randPlayerNamesList[randNumber]);
            playerName = "[" + playerName + "]";

            PrintLong("How about: " + playerName + "?", 39, " ", 1900, "\n\nYes,", 19, " ", 800, playerName + " will do nicely.", 13, " ", 900, "", 0);
        }
        else
        {
            Print("Yes,", 39);
            Thread.Sleep(500);
            Print(" that'll do nicely.", 26);
            userIsUncooperative = false;
            Thread.Sleep(900);
        }





        // Picking the antagonist's name (copied code from above)


        Print("\n\nNow Who will our Brave Protagonist be fighting back against?\n", 23);

        Console.Write("Your enemy's name: ");
        string antogonistName = Console.ReadLine();

        antogonistName = "[" + antogonistName + "]";

        if (antogonistName == "[]") 
        {
            Print("\nGot writer's block?", 13);
            Thread.Sleep(1600);
            Print(" Don't worry, son!\n", 23);
            Thread.Sleep(600);
            Print("I'll help you think of something!\n\n", 18);
            Thread.Sleep(1800);

            // Fun fact, the antagonist's name used to be determined by the initial input at the beginning before i decided to do some funny lore stuff, i couldve made it tie together but i felt like there'd be too many people who'd put gibberish as the name which would kinda suck, so this way people at least know what they're doing
            // the downside of this is that its less likely that people will find the funny names, but thats fine, i may alter this list and reuse some things for the userIsUncooperative Tag (i may name the path after "randAntagonistNamesList" 1; Consequence of Sloth)
            
            // tldr: i made this list before the playerName list and also i might redo this one and resue some of the names for other stuff

            string[] randAntagonistNames = { "This Integer Is Impossible To Have Appear!", "Consequence of Sloth", "Big Meanie", "THIS! USER! IS! LAZY!!!", "lmaooooo", "Antagonist", "Reverend of Sloth", "START!", "Maybe you should have inputted something for the first input...", "ERROR", "INPUT", "INPUT_UNREGISTERED", "An unexpected error has occurred in pulling \"string(startInput)\", please refer to https://dotnet.microsoft.com/en-us/platform/support for more information.", "Advent of Hell", "(insert edgy title/name here)", "The One who Wins", "The Great Adversary", "Xx_Samurai_R_C0ol_xX", "sans" };
            List<string> randAntagonistNamesList = new List<string>(randAntagonistNames);
            randNumber = rnd.Next(1, 20);
            antogonistName = (randAntagonistNamesList[randNumber]);
            antogonistName = "[" + antogonistName + "]";

            Print("What about: " + antogonistName + "?\n\n", 39);
            Thread.Sleep(1900);
            Print(antogonistName + " sounds good to me!", 13);
        }
        else
        {
            Print(antogonistName + "?", 39);
            Thread.Sleep(700);
            Print(" Sounds good to me!", 39);
            userIsUncooperative = false;
        }


        Thread.Sleep(2000);


        TextPrecursor(0, true);
        TextPrecursor(0, true);
        TextPrecursor(1, true);
        PrintLong(playerName + " awakes like any other day,", 17, " ", 900, "in his cloud-like bed in his room in the small town of Rudville,", 19," ", 1500, "a quiet town located in beautiful lush green plains.", 23, " ", 2300, "", 0);

        TextPrecursor(1, true);
        PrintLong(playerName + " lies there,", 23, " ", 1100, "smug about how much better their life is than everybody else's,", 23, " ", 1600, "and how much cooler and better he is than everyone else (as if this ", 23, "\n", 23, "", 0);

        TextPrecursor(1, true);
        Print("was something up for debate(it was not)).", 23);
        Thread.Sleep(1700);
        TextPrecursor(1, true);
        TextPrecursor(1, true);
        PrintLong("Today is Saturday,", 23, " ", 300, "(his second-favourite day).", 23, " ", 300, "So he goes out to frolic in the flower fields", 23, " ", 200, "while thinking about the fact he is vastly better than everyone else.\n", 23);
        Thread.Sleep(3100);

        TextPrecursor(1, true);
        Print("\"I am better than everyone else in every way!~\", he sang, \"Even that shitty old man who beat swordsmanship into me! Well, not that I can PROVE I'm better, but it doesn't matter if I prove it! I'm still the best!~\"\n", 23);
        Thread.Sleep(3100);
        TextPrecursor(1, true);
        Print("He was then promptly struck by lightning and immediately died", 23);
        Thread.Sleep(1300);
        Print("...", 850);
        Thread.Sleep(1100);
        Print(" Is what WOULD'VE happened", 23);
        Thread.Sleep(700);
        Print(", if this was an ordinary lightning bolt...", 23);
        Print("", 23);
        TextPrecursor(1, true);












        Thread.Sleep(3000);
    }
    public static void Print(string text, int speed)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
    }
    public static void TextPrecursor(int textType, bool createOnNewLine) // may add a colour tag if i feel the need to later on
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
    public static void PrintLong(string text, int speed, string text1, int speed1, string text2, int speed2, string text3, int speed3, string text4, int speed4, string text5, int speed5, string text6, int speed6)
    {
        
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }
        foreach (char c in text1)
        {
            Console.Write(c);
            Thread.Sleep(speed1);
        }
        foreach (char c in text2)
        {
            Console.Write(c);
            Thread.Sleep(speed2);
        }
        foreach (char c in text3)
        {
            Console.Write(c);
            Thread.Sleep(speed3);
        }
        foreach (char c in text4)
        {
            Console.Write(c);
            Thread.Sleep(speed4);
        }
        foreach (char c in text5)
        {
            Console.Write(c);
            Thread.Sleep(speed5);
        }
        foreach (char c in text6)
        {
            Console.Write(c);
            Thread.Sleep(speed6);
        }
    }
    public static void ascii(int ascii, int newLineSpeed, int typingSpeed)
    {
        if (ascii == 0)
        {
            // TODO: add placeholder art
        }
        else if (ascii == 1)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Print("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&\n", typingSpeed);
                Thread.Sleep(newLineSpeed);
            };
            Print("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&       ", typingSpeed);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Print("##################", typingSpeed);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Print("(      *", typingSpeed);
            Console.ForegroundColor = ConsoleColor.Gray;
            Print("%%%%%%%&&&&&&&&&&&&&&&&%&&&&&&&&&\n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("&&&&&&&&&&&&&&&&&&&&&&&&%%%%", typingSpeed);
            Console.ForegroundColor = ConsoleColor.Black;
            Print(".            ", typingSpeed);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Print("((###############(             ", typingSpeed);
            Console.ForegroundColor = ConsoleColor.Gray;
            Print("%%%%%%%&&&&&&&&&&%&&&&&&&&&&\n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("&&&", typingSpeed);
            Console.ForegroundColor = ConsoleColor.Gray;
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
            Print("", typingSpeed);
        }
        else if (ascii == 2)
        {
            Print("     .----------------.   .----------------.   .----------------.                     Welcome to:\n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | .--------------. | | .--------------. | | .--------------. |      ______         ______        __       __        __    __        __               ______         ________         ______         _______    \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | |  _______     | | | |   ______     | | | |    ______    | |     /      \\       |      \\      |  \\     /  \\      |  \\  |  \\      |  \\             /      \\       |        \\       /      \\       |       \\   \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | | |_   __ \\    | | | |  |_   __ \\   | | | |  .' ___  |   | |    |  $$$$$$\\       \\$$$$$$      | $$\\   /  $$      | $$  | $$      | $$            |  $$$$$$\\       \\$$$$$$$$      |  $$$$$$\\      | $$$$$$$\\  \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | |   | |__) |   | | | |    | |__) |  | | | | / .'   \\_|   | |    | $$___\\$$        | $$        | $$$\\ /  $$$      | $$  | $$      | $$            | $$__| $$         | $$         | $$  | $$      | $$__| $$  \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | |   |  __ /    | | | |    |  ___/   | | | | | |    ____  | |     \\$$    \\         | $$        | $$$$\\  $$$$      | $$  | $$      | $$            | $$    $$         | $$         | $$  | $$      | $$    $$   \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | |  _| |  \\ \\_  | | | |   _| |_      | | | | \\ `.___]  _| | |     _\\$$$$$$\\        | $$        | $$\\$$ $$ $$      | $$  | $$      | $$            | $$$$$$$$         | $$         | $$  | $$      | $$$$$$$\\  \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | | |____| |___| | | | |  |_____|     | | | |  `._____.'   | |    |  \\__| $$       _| $$_       | $$ \\$$$| $$      | $$__/ $$      | $$_____       | $$  | $$         | $$         | $$__/ $$      | $$  | $$  \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | |              | | | |              | | | |              | |     \\$$    $$      |   $$ \\      | $$  \\$ | $$       \\$$    $$      | $$     \\      | $$  | $$         | $$          \\$$    $$      | $$  | $$  \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("    | '--------------' | | '--------------' | | '--------------' |      \\$$$$$$        \\$$$$$$       \\$$      \\$$        \\$$$$$$        \\$$$$$$$$       \\$$   \\$$          \\$$           \\$$$$$$        \\$$   \\$$  \n", typingSpeed);
            Thread.Sleep(newLineSpeed);
            Print("     '----------------'   '----------------'   '----------------'                                                                                                              Designed, Written and Created by K\n\n\n\n", typingSpeed);
            Thread.Sleep(newLineSpeed);
        }
    }
    public static void CursorTest()
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
    public static void GenerateHealthBar()
    {
        bool updateHealthBar = true;
        while (true)
        {




            if (updateHealthBar = false); { break; }
        }
    }
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
public class ConsoleRectangle
{
    private int hWidth;
    private int hHeight;
    private Point hLocation;
    private ConsoleColor hBorderColor;

    public ConsoleRectangle(int width, int height, Point location, ConsoleColor borderColor)
    {
        hWidth = width;
        hHeight = height;
        hLocation = location;
        hBorderColor = borderColor;
    }

    public Point Location
    {
        get { return hLocation; }
        set { hLocation = value; }
    }

    public int Width
    {
        get { return hWidth; }
        set { hWidth = value; }
    }

    public int Height
    {
        get { return hHeight; }
        set { hHeight = value; }
    }

    public ConsoleColor BorderColor
    {
        get { return hBorderColor; }
        set { hBorderColor = value; }
    }

    public void Draw()
    {
        string s = "╔";
        string space = "";
        string temp = "";
        for (int i = 0; i < Width; i++)
        {
            space += " ";
            s += "═";
        }

        for (int j = 0; j < Location.X; j++)
            temp += " ";

        s += "╗" + "\n";

        for (int i = 0; i < Height; i++)
            s += temp + "║" + space + "║" + "\n";

        s += temp + "╚";
        for (int i = 0; i < Width; i++)
            s += "═";

        s += "╝" + "\n";

        Console.ForegroundColor = BorderColor;
        Console.CursorTop = hLocation.Y;
        Console.CursorLeft = hLocation.X;
        Console.Write(s);
        Console.ResetColor();
    }
}
