namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            FavouriteNumberGame();

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
        
    }
}
