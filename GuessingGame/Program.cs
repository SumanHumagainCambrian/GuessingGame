// See https://aka.ms/new-console-template for more information
using GuessingGame;

Console.WriteLine("Hello, World!");


Random random = new Random();
int randomInt = random.Next(1, 101);

List<Guess> guessList = new List<Guess>();

int userGuess = 0; // variable to hold the users guess

do
{
    Console.Write("Enter your guess: ");
    string userInput = Console.ReadLine();

    if (!int.TryParse(userInput, out userGuess))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        continue;
    }

    guessList.Add(new Guess(userGuess)); // If its number then only adding to guess list

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
