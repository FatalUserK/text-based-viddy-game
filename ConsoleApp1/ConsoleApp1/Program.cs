using System;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
class Program
{

    public static void Main(string[] args)
    {
        // Wow, look! What a cool game...
        //
        // I wonder
        //          if anyone's
        //                      going to
        //                               make it
        //                                       :)

        Print("Wow,", 1);
        Thread.Sleep(1000);

        Print(" look!", 1);
        Thread.Sleep(1500);

        Print(" What a cool game", 1);
        Thread.Sleep(1500);

        Print("...", 1500);
        Thread.Sleep(2000);

        // "Wow, look! What a cool game" is a meta reference showing that this game is likely to be less formal with its humor and story since its acknowledging itself as a game

        Print("\n\nI wonder\n", 15);
        Thread.Sleep(500);
        Print("         ", 0);
        Print("if anyone's\n", 15);
        Thread.Sleep(500);
        Print("                     ", 0);
        Print("going to\n", 15);
        Thread.Sleep(500);
        Print("                              ", 0);
        Print("make it\n", 15);
        Thread.Sleep(800);
        Print("                                      ", 0);
        Print(":)\n", 5);
        Thread.Sleep(1500);

        // ^ this is initially just a funny little intro i made for fun but i could give it some meaning later on or in a later iteration of this project, such as the game ending with everyone dying, showing that nobody is "going to make it"



        // holds off on running the scripts that put the game together until the player enters an input, this act as a gatekeeper as it were but will also act as the input for the main antagonist.
        // The User is probably unaware of this and will likely bring some sort of gratification knowing this choice had some sort of payoff in the long run,
        // This could also lead to some comedic moments later on deciding on the input the user decided on

        Console.WriteLine("\n\n\n\n[Type anything START]\n");


        // randomise list set up in the event the user does not enter inputs when required

        // The Names here are chosen either to be funny or punish the player in some way, however some "normal" names were thrown in to even out the experience and to make the other ones feel more special, a sort of filler
        string[] randStartInput = { "This Integer Is Impossible To Have Appear!", "Consequence of Sloth", "Big Meanie", "THIS! USER! IS! LAZY!!!", "lmaooooo", "Antagonist", "Reverend of Sloth", "START!", "Maybe you should have inputted something for the first input...", "ERROR", "INPUT", "INPUT_UNREGISTERED", "An unexpected error has occurred in pulling \"string(startInput)\", please refer to https://dotnet.microsoft.com/en-us/platform/support for more information.", "Advent of Hell", "(insert edgy title/name here)", "The One who Wins", "The Great Adversary", "Xx_Samurai_R_C0ol_xX", "sans" };
        List<string> randStartInputList = new List<string>(randStartInput);

        // god im going to lose track of all these comments, arent i?

        Random rnd = new Random();
        int randNumber = rnd.Next(1, 19);
        
        //Console.WriteLine(randStartInputList[randNumber]);
        string startInput = Console.ReadLine();

        if (string.IsNullOrEmpty(startInput))
           {
                startInput = (randStartInputList[randNumber]);
           }

        // runs various scripts that will help optimise things later on

        string playerName = "PLAYER";
        string userInputEcho = playerName + " has made the input: ";

        // Print 
        Print(userInputEcho, 0);
        Print(startInput, 0);
        Print("", 1500);
        Print("...", 1500);
        Console.WriteLine();

        Thread.Sleep(3000);

        Print("\n\nWARNING! USER INPUT DETECTED,", 2);
        Thread.Sleep(1200);
        Print(" SENDING REQUEST FOR RESPONSE 221B", 2);
        Print("...", 800);

        Thread.Sleep(1500);

        Print("\n\nRESPONSE RECEIVED, INITIALISING OIS", 2);
        Print("...", 1200);






        Print("Operator Interaction System Initialised...\n\n", 10);

        Thread.Sleep(1200);

        string textTemp = "Analysing Trace...\n";               // sets the text that will be sent
        foreach (char c in textTemp)                            // runs the script for every letter left in the designated string [textTemp]
        {
            randNumber = rnd.Next(5, 100);                      // picks a random number between 5 and 500
            Print(c.ToString(), randNumber);                    // sends the next letter from [textTemp] that hasnt already been sent and then make the thread sleep the by the amount designated by the random number above


        }
        Thread.Sleep(2000);

        textTemp = "Trace Discovered...\n";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(5, 100);
            Print(c.ToString(), randNumber);


        }
        Thread.Sleep(2000);

        textTemp = "Locking onto Source...\n";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(5, 100);
            Print(c.ToString(), randNumber);


        }
        Thread.Sleep(2000);
        textTemp = "Entity Located, sending EDCP";
        foreach (char c in textTemp)
        {
            randNumber = rnd.Next(10, 200);
            Print(c.ToString(), randNumber);


        }
        Print("...\n", 1000);

        textTemp = "54686520  456e6420  6f662047  6f642077\n696c6c20  42656661  6c6c2075  7320416c\n6c0d0a41  73207765  2044616e  63652062\n65666f72  65206869  7320436f  72707365\n20696e20  74686520  48616c6c  206f6620\n54687261  6c6c0d0a  42652073  74696c6c\n2c20616e  64206769  76652075  70204574\n65726e61  6c205265  73740d0a  4173206f\n75722044  61726b20  54686f75  67687473\n20626567  696e2074  6f204665  7374\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";



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
    
}