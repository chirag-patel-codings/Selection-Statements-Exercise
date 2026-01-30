namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // FavouriteNumberGame();
            FavouriteSubjectGame();

        }
        
        // This function generates in the random number and validates the input supplied by user
        static void FavouriteNumberGame()
        {
            int minGuessValue = 1;
            int maxGuessValue = 50;
            int userInput;
            
            // Generating a random number between MIN and MAX Values
            Random r = new Random();
            int favNumber = r.Next(minGuessValue, maxGuessValue);
            
            Console.WriteLine($"Can you guess, what is my Favourite Number between {maxGuessValue} and {minGuessValue}?");
            
            // Added to check the guessed number...
            // Console.WriteLine(favNumber);
            
            // Take the user input and validate it
            do
            {
                userInput = GetUserInput();
                if (userInput > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("You Guessed it!!!");
                }
            } while (favNumber != userInput);
        }

        // Gets the valid user input and returns to the calling function
        static int GetUserInput()
        {
            int userInput;
            
            do
            {
                Console.Write("Please enter your guess in numeric only!\n");
            }while (!int.TryParse(Console.ReadLine().Trim(), out userInput));
            
            return userInput;
        }

        
        // This function provides the Favourite Subect Game
        static void FavouriteSubjectGame()
        {
            
            string displayMessage;
            
            Console.WriteLine("What is your favorite school subject?");
            Console.WriteLine("Math | Science | History | Music | English");
            
            string userInput = Console.ReadLine().Trim();

            switch (userInput.ToLower())
            {
                case "math":
                    displayMessage = "Math is cool because it's all about solving problems!";
                    break;
                case "science":
                case "sci":
                    displayMessage = "Great! Science is all about practical experiments!";
                    break;
                case "history":
                case "his":
                    displayMessage = "Every time you study History, you unlock a mystery!";
                    break;
                case "music":
                    displayMessage = "Music is memory, math, emotion, and rebellion all at once!";
                    break;
                case "english":
                case "eng":
                    displayMessage = "English gives you millions of stories, voices, and ideas—yours can be one of them!";
                    break;
                default:
                    displayMessage = "Interesting choice! What do you like about it?";
                    break;
            }
            Console.WriteLine(displayMessage);
            
        }
        
    }
}
