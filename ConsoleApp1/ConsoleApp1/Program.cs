using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;
using System.Drawing;
using System.Formats.Asn1;
using System.Text;
using ConsoleApp1;
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

        GameText.Print("Wow,", 1, " ", 700, "look!", 1, " ", 1300, "What a cool gam", 1, "e", 1500, "...", 900);
        Thread.Sleep(2000);


        //////////////////////////////////////////// TESTING SPACE START ////////////////////////////////////


        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
        //player.Play();







        //////////////////////////////////////////// TESTING SPACE END ////////////////////////////////////


        // "Wow, look! What a cool game" is a meta reference showing that this game is likely to be less formal with its humor and story since its acknowledging itself as a game
        Console.ForegroundColor = ConsoleColor.Green;
        GameText.Print("\n\nI wonder\n", 15);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Yellow;
        GameText.Print("         ", 0);
        GameText.Print("if anyone's\n", 15);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Red;
        GameText.Print("                     ", 0);
        GameText.Print("going to\n", 15);
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Magenta;
        GameText.Print("                              ", 0);
        GameText.Print("make it\n", 15);
        Thread.Sleep(800);
        Console.ForegroundColor = ConsoleColor.Blue;
        GameText.Print("                                      ", 0);
        GameText.Print(":)\n", 5);
        Thread.Sleep(1500);

        // ^ this is initially just a funny little intro i made for fun but i could give it some meaning later on or in a later iteration of this project, such as the game ending with everyone dying, showing that nobody is "going to make it"



        // holds off on running the scripts that put the game together until the player enters an input, this act as a gatekeeper as it were but will also act as the input for the main antagonist.
        // The User is probably unaware of this and will likely bring some sort of gratification knowing this choice had some sort of payoff in the long run,
        // This could also lead to some comedic moments later on deciding on the input the user decided on
        GameText.Print("\n\n\n\n[Type anything to ", 10);
        Console.ForegroundColor = ConsoleColor.Yellow;
        GameText.Print("START", 10);
        Console.ForegroundColor = ConsoleColor.Blue;
        GameText.Print("]\n\n", 10);


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
                GameText.Precursor(0, true);
                GameText.Print("Empty", 20);
                GameText.Precursor(1, true);
                GameText.Print("Narrative", 20);
                GameText.Precursor(2, true);
                GameText.Print("Action", 20);
                GameText.Precursor(3, true);
                GameText.Print("Mystery", 20);
                GameText.Precursor(4, true);
                GameText.Print("Description", 20);
                GameText.Precursor(5, true);
                GameText.Print("Null", 20);
                GameText.Precursor(6, true);
                GameText.Print("Null", 20);
                GameText.Precursor(7, true);
                GameText.Print("Null", 20);
                GameText.Precursor(8, true);
                GameText.Print("Null", 20);
                GameText.Precursor(9, true);
                GameText.Print("Null", 20);

                randNumber = rnd.Next(0, 1000);

                GameText.Print("\n\n0-1000: " + randNumber, 20);
                GameText.Print("3 2 1 ", 500);
                GameText.Print("GO!", 0);

                DateTime startTimerTest = DateTime.UtcNow;           // https://stackoverflow.com/questions/27359345/how-to-check-if-specific-time-has-passed
                TimeSpan timerLengthTest = TimeSpan.FromSeconds(3);
                int countTest = 0;
                while (DateTime.UtcNow - startTimerTest < timerLengthTest)
                {
                    if (Console.KeyAvailable)                    // https://stackoverflow.com/questions/63818349/c-sharp-net-console-application-getting-keyboard-input
                    {
                        var key = Console.ReadKey(true);

                        switch (key.Key)
                        {
                            case ConsoleKey.Spacebar:
                                countTest++;
                                break;
                        }
                    }
                }
                GameText.Print("You pressed the Spacebar " + countTest + " times!", 20);

                GameText.Print("\n\nRunning Text Delay Test in ", 20);
                GameText.Print("3 2 1\n", 500);
                GameText.Print("  <<<<10>>>>  ", 10, "  <<<<50>>>>", 50, "  <<<<100>>>>  ", 100, "  <<<<500>>>>  ", 500, "  <<<<1000>>>> ", 1000, "  <<<<5000>>>>  ", 5000, "  <<<<10000>>>>  ", 10000);

                startInput = "";
            }


            else if (startInput == "math")
            {
                ascii(1, 10, 10);


                //universaltemp1 == (universaltemp1.ToString)
                //universaltemp1.ToString = Console.ReadLine();
                //String.ToInt32 universaltemp1;



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
                    GameText.Print("\n\nSuperman, Batman, Thor, God, Ironman:\n", 20);
                    hero = Console.ReadLine();
                    if (heroesList.Contains(hero)) { heroValidInput++; }
                    else if (hero.Length < 1) { GameText.Print("\nPlease give an input.", 20); }
                    else if (heroInputFailure <= 5) { GameText.Print("\nPlease give a valid input.", 20); heroInputFailure++; }
                    else { GameText.Print("\nPlease give a valid input, note that the input is Case-sensitive", 20); }
                }
                GameText.Print("Thank you for your input...\n", 20);
                if (hero == "Superman") { GameText.Print("He can do literally anything but is stupid", 20); }
                else if (hero == "Batman") { GameText.Print("He's angsty and rich", 20); }
                else if (hero == "Thor") { GameText.Print("Theoretically a God of Thunder, really just some overweight Fortnite player", 20); }
                else if (hero == "God") { GameText.Print("Basically Superman but better", 20); }
                else if (hero == "Ironman") { GameText.Print("Weak as shit but rich and smart as hell", 20); }
                else { GameText.Print("WHAT THE FUCK", 60); };
                startInput = "";
            }

            if (startInput == "CursorTest") { CursorTest.Cursor(); }




            else if (startInput == "fight")
            { }




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



        if (startInput == "2.2")
        {
            string name = "";
            List<string> nameList = new List<string>();
            nameList.Add("Biff"); // adding elements using add() method
            nameList.Add("Chip");
            nameList.Add("Kipper");
            nameList.Add("Hans");
            nameList.Add("Super");

            for (int i = 0; i < nameList.Count; i++)
            {
                name = nameList[i];
                if (name.Length != 4)
                {
                    Console.WriteLine("INVALID!");

                }
                else { Console.WriteLine(name); }
            }



            if (string.IsNullOrEmpty(startInput))
            {
                //startInput = (randStartInputList[randNumber]);
                Console.ForegroundColor = ConsoleColor.White;
                GameText.Print("\nFALSE POSITIVE DETECTED,", 20);
                Thread.Sleep(500);
                GameText.Print(" RETURNING TO DORMANT STATE", 20);
                Thread.Sleep(1200);
                Console.ForegroundColor = ConsoleColor.Blue;
                GameText.Print("\n\n\n\n[Type anything to ", 10);
                Console.ForegroundColor = ConsoleColor.Yellow;
                GameText.Print("START", 10);
                Console.ForegroundColor = ConsoleColor.Blue;
                GameText.Print("]\n", 10);

            }


        }



        // runs various scripts that will help optimise things later on

        string playerName = "USER";
        string userInputEcho = playerName + " has made the input: ";
        startInput = "[" + startInput + "]";

        Console.ForegroundColor = ConsoleColor.Blue;

        // Print 
        GameText.Print("\n" + userInputEcho, 0);
        Console.ForegroundColor = ConsoleColor.White;
        GameText.Print(startInput, 0);
        Thread.Sleep(1500);
        Console.ForegroundColor = ConsoleColor.Blue;
        GameText.Print("...", 800);
        Console.WriteLine();



        Thread.Sleep(1400);
        Console.ForegroundColor = ConsoleColor.Red;

        GameText.Print("\n\nWARNING! USER INPUT DETECTED,", 2);
        Console.ForegroundColor = ConsoleColor.White;
        Thread.Sleep(600);
        GameText.Print(" REQUESTING FOR RESPONSE FROM UNIT 221B", 2);
        Thread.Sleep(400);
        GameText.Print("...", 400);

        Thread.Sleep(1500);

        GameText.Print("\n\nRESPONSE RECEIVED, INITIALISING OIS", 2);
        Thread.Sleep(600);
        GameText.Print("...", 600);


        Thread.Sleep(1500);



        GameText.Print("\n\n\nOperator Interaction System Initialised...\n\n", 10);

        Thread.Sleep(1200);
        Console.ForegroundColor = ConsoleColor.Gray;
        string textTemp = "Analysing Trace...\n";               // sets the text that will be sent
        foreach (char c in textTemp)                            // runs the script for every letter left in the designated string [textTemp]
        {
            randNumber = rnd.Next(5, 140);                      // picks a random number between 5 and 500
            GameText.Print(c.ToString(), 40);                    // sends the next letter from [textTemp] that hasnt already been sent and then make the thread sleep the by the amount designated by the random number above

            // previously replaced "randNumber" with "40"

        }                                  // TODO: SIMPLIFY THIS INTO A FUNCTION, HAVENT DONE THIS YET AS I ACTUALLY DONT NEED IT RN
        Thread.Sleep(2000);

        textTemp = "Trace Discovered...\n";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(5, 140);
            GameText.Print(c.ToString(), 40);            // previously replaced "randNumber" with "40"


        }
        Thread.Sleep(2000);

        textTemp = "Locking onto Source...\n";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(5, 140);
            GameText.Print(c.ToString(), 40);            // previously replaced "randNumber" with "40"


        }
        Thread.Sleep(2000);
        textTemp = "Entity Located, sending EDCP";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(30, 250);
            GameText.Print(c.ToString(), 40);            // previously replaced "randNumber" with "40"


        }
        GameText.Print("...\n", 300);



        textTemp = "54686520  456e6420  6f662047  6f642077\n696c6c20  42656661  6c6c2075  7320416c\n6c0d0a41  73207765  2044616e  63652062\n65666f72  65206869  7320436f  72707365\n20696e20  74686520  48616c6c  206f6620\n54687261  6c6c0d0a  42652073  74696c6c\n2c20616e  64206769  76652075  70204574\n65726e61  6c205265  73740d0a  4173206f\n75722044  61726b20  54686f75  67687473\n20626567  696e2074  6f204665  7374\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";

        Thread.Sleep(2000);

        int startIndex = 0;
        int length = 39;
        int tempCount = 0;

        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int i = 0; i < 5; i++)
        {
            String substring = textTemp.Substring(startIndex, length);
            GameText.Print(substring, 0);
            tempCount = (tempCount + 1);
            startIndex = startIndex + 39;
            Thread.Sleep(30);
        }

        Console.ForegroundColor = ConsoleColor.White;
        GameText.Print("INITIATING ", 1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        GameText.Print("PACIFIER PROTOCOL", 1);

        GameText.Print("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n", 1);

        ascii(2, 5, 0);

        Console.ForegroundColor = ConsoleColor.White;

        GameText.Print("Welcome,", 13);
        Thread.Sleep(800);
        GameText.Print(" Brave,", 13, " ", 13, "New", 13, " Adventurer,", 13, " ", 1100, "to the land of ", 13, "", 0);
        Console.ForegroundColor = ConsoleColor.Yellow;
        GameText.Print("[RPG SIMULATOR]", 70);
        Console.ForegroundColor = ConsoleColor.White;
        GameText.Print("!\n\n", 10);

        Thread.Sleep(1500);




        // Picking the player's name

        bool userIsUncooperative = true;
        GameText.Print("Tell me, young lad,", 13);
        Thread.Sleep(1100);
        GameText.Print(" who is this legend about?\n", 43);

        Console.Write("Your name: ");
        playerName = Console.ReadLine();

        playerName = "[" + playerName + "]";


        GameText.Print("\n" + playerName + ",", 70);
        Thread.Sleep(650);
        GameText.Print(" huh?\n\n", 13);
        Thread.Sleep(1300);
        if (playerName == "[]")
        {
            GameText.Print("Well I suppose if you don't want to answer,", 13);
            Thread.Sleep(800);
            GameText.Print(" it can't be helped.\n", 13);
            Thread.Sleep(1600);
            GameText.Print("However you still need a name,", 23);
            Thread.Sleep(600);
            GameText.Print(" I'll have to call you something!\n\n", 18);
            Thread.Sleep(1800);


            string[] randPlayerNames = { "Good Luck Getting This One!", "The Great Saviour", "Butter", "Harry", "The One who Wins", "Probably God", "ERROR IS YOU!", "A Fatal Error HASNT Occurred!", ":)", "Demon Slaughterer", "Devout One", "Apostle of God", "Pawn of a Higher Being", "There are strings on me!", "Distraction", "You", "Cannot", "Escape", "An Actor of God", "Puppet Boy" };
            List<string> randPlayerNamesList = new List<string>(randPlayerNames);
            randNumber = rnd.Next(1, 20);
            playerName = (randPlayerNamesList[randNumber]);
            playerName = "[" + playerName + "]";

            GameText.Print("How about: " + playerName + "?", 39, " ", 1900, "\n\nYes,", 19, " ", 800, playerName + " will do nicely.", 13, " ", 900, "", 0);
        }
        else
        {
            GameText.Print("Yes,", 39);
            Thread.Sleep(500);
            GameText.Print(" that'll do nicely.", 26);
            userIsUncooperative = false;
            Thread.Sleep(900);
        }





        // Picking the antagonist's name (copied code from above)


        GameText.Print("\n\nNow Who will our Brave Protagonist be fighting back against?\n", 23);

        Console.Write("Your enemy's name: ");
        string antogonistName = Console.ReadLine();

        antogonistName = "[" + antogonistName + "]";

        if (antogonistName == "[]")
        {
            GameText.Print("\nGot writer's block?", 13);
            Thread.Sleep(1600);
            GameText.Print(" Don't worry, son!\n", 23);
            Thread.Sleep(600);
            GameText.Print("I'll help you think of something!\n\n", 18);
            Thread.Sleep(1800);

            // Fun fact, the antagonist's name used to be determined by the initial input at the beginning before i decided to do some funny lore stuff, i couldve made it tie together but i felt like there'd be too many people who'd put gibberish as the name which would kinda suck, so this way people at least know what they're doing
            // the downside of this is that its less likely that people will find the funny names, but thats fine, i may alter this list and reuse some things for the userIsUncooperative Tag (i may name the path after "randAntagonistNamesList" 1; Consequence of Sloth)

            // tldr: i made this list before the playerName list and also i might redo this one and resue some of the names for other stuff

            string[] randAntagonistNames = { "This Integer Is Impossible To Have Appear!", "Consequence of Sloth", "Big Meanie", "THIS! USER! IS! LAZY!!!", "lmaooooo", "Antagonist", "Reverend of Sloth", "START!", "Maybe you should have inputted something for the first input...", "ERROR", "INPUT", "INPUT_UNREGISTERED", "An unexpected error has occurred in pulling \"string(startInput)\", please refer to https://dotnet.microsoft.com/en-us/platform/support for more information.", "Advent of Hell", "(insert edgy title/name here)", "The One who Wins", "The Great Adversary", "Xx_Samurai_R_C0ol_xX", "sans" };
            List<string> randAntagonistNamesList = new List<string>(randAntagonistNames);

            randNumber = rnd.Next(1, 20);

            antogonistName = (randAntagonistNamesList[randNumber]);
            antogonistName = "[" + antogonistName + "]";

            GameText.Print("What about: " + antogonistName + "?\n\n", 39);
            Thread.Sleep(1900);
            GameText.Print(antogonistName + " sounds good to me!", 13);
        }
        else
        {
            GameText.Print(antogonistName + "?", 39);
            Thread.Sleep(700);
            GameText.Print(" Sounds good to me!", 39);
            userIsUncooperative = false;
        }


        Thread.Sleep(2000);


        GameText.Precursor(0, true);
        GameText.Precursor(0, true);
        GameText.Precursor(1, true);
        GameText.Print(playerName + " awakes like any other day,", 17, " ", 900, "in his cloud-like bed in his room in the small town of Rudville,", 19, " ", 1500, "a quiet town located in beautiful lush green plains.", 23, " ", 2300, "", 0);

        GameText.Precursor(1, true);
        GameText.Print(playerName + " lies there,", 23, " ", 1100, "smug about how much better their life is than everybody else's,", 23, " ", 1600, "and how much cooler and better he is than everyone else (as if this ", 23, "\n", 23, "", 0);

        GameText.Precursor(1, true);
        GameText.Print("was something up for debate(it was not)).", 23);
        Thread.Sleep(1700);
        GameText.Precursor(1, true);
        GameText.Precursor(1, true);
        GameText.Print("Today is Saturday,", 23, " ", 300, "(his second-favourite day).", 23, " ", 300, "So he goes out to frolic in the flower fields", 23, " ", 200, "while thinking about the fact he is vastly better than everyone else.\n", 23);
        Thread.Sleep(3100);

        GameText.Precursor(1, true);
        GameText.Print("\"I am better than everyone else in every way!~\", he sang, \"Even that shitty old man who beat swordsmanship into me! Well, not that I can PROVE I'm better, but it doesn't matter if I prove it! I'm still the best!~\"\n", 23);
        Thread.Sleep(3100);
        GameText.Precursor(1, true);
        GameText.Print("He was then promptly struck by lightning and immediately died", 23);
        Thread.Sleep(1300);
        GameText.Print("...", 850);
        Thread.Sleep(1100);
        GameText.Print(" Is what WOULD'VE happened", 23);
        Thread.Sleep(700);
        GameText.Print(", if this was an ordinary lightning bolt...", 23);
        GameText.Print("", 23);
        GameText.Precursor(1, true);












        Thread.Sleep(3000);
    }

    public static void ascii(int a, int b, int c)
    {

    }






}
    

