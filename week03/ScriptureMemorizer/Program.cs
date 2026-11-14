
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference.
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Scripture text.
        string text = "Trust in the LORD with all thine heart; " +
                      "and lean not unto thine own understanding. " +
                      "In all thy ways acknowledge him, " +
                      "and he shall direct thy paths.";

        // Create the scripture object.
        Scripture scripture = new Scripture(reference, text);

        // Display the full scripture.
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Continue until all words are hidden or the user quits.
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine(
                $"Words remaining: {scripture.GetWordsRemaining()}"
            );

            Console.WriteLine(
                "Press Enter to hide words or type 'quit' to exit."
            );

            string choice = Console.ReadLine();

            if (choice.ToLower() == "quit")
            {
                break;
            }

            // Hide three random words each time Enter is pressed.
            scripture.HideRandomWords(3);

            // Clear the screen and display the updated scripture.
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations! You memorized the scripture!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Keep practicing. You can do it!");
        }
    }
}

/*
Extra Feature:
I added a progress counter that shows how many words are
still visible as the user practices memorizing the scripture.

I also made the program select only words that have not
already been hidden. This prevents the same word from
being selected again and helps the user make progress.
*/
