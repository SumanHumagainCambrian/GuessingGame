// See https://aka.ms/new-console-template for more information
using GuessingGame;


Random random = new Random();
int randomInt = random.Next(1, 101);

List<Guess> guessList = new List<Guess>();

int userGuess = 0; // variable to hold the users guess

do
{
    Console.Write("\n Enter your guess: ");
    string userInput = Console.ReadLine();

    if (!int.TryParse(userInput, out userGuess))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        continue;
    }

    int findIndexInPreviousGuessList = guessList.FindIndex(x => x.UserGuess == userGuess);
    if (findIndexInPreviousGuessList != -1)
    {
        Console.WriteLine($"You guessed this number {guessList.Count - findIndexInPreviousGuessList} turns ago!");
    }
    guessList.Add(new Guess(userGuess)); // If its number then only adding to guessList

    if (userGuess > randomInt)
    {
        Console.WriteLine("Your guess is found high!");
    }
    else if (userGuess < randomInt)
    {
        Console.WriteLine("Your guess is found low!");
    }
}
while (userGuess != randomInt);

//If matched 
Console.WriteLine($"You Won! The answer was {randomInt}.");
