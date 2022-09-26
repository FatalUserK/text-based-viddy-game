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
        Thread.Sleep(3000);

        // "Wow, look! What a cool game" is a meta reference showing that this game is likely to be less formal with its humor and story since its acknowledging itself as a game

        Print("\n\nI wonder\n", 15);
        Thread.Sleep(700);
        Print("         ", 0);
        Print("if anyone's\n", 15);
        Thread.Sleep(700);
        Print("                     ", 0);
        Print("going to\n", 15);
        Thread.Sleep(700);
        Print("                              ", 0);
        Print("make it\n", 15);
        Thread.Sleep(1400);
        Print("                                      ", 0);
        Print(":)\n", 5);
        Thread.Sleep(2000);

        // ^ this is initially just a funny little intro i made for fun but i could give it some meaning later on or in a later iteration of this project, such as the game ending with everyone dying, showing that nobody is "going to make it"



        // holds off on running the scripts that put the game together until the player enters an input, this act as a gatekeeper as it were but will also act as the input for the main antagonist.
        // The User is probably unaware of this and will likely bring some sort of gratification knowing this choice had some sort of payoff in the long run,
        // This could also lead to some comedic moments later on deciding on the input the user decided on

        Console.WriteLine("\n\n\n\n[Type anything START]");


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
        Print("... ", 1500);
        Console.WriteLine();

        Thread.Sleep(3000);

        Print("Trace Discovered...\n", randNumber);
        Print("Locking onto Source...\n", 300);

        

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