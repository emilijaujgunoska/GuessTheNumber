Random random = new();
bool tryAgain = true;
int min = 1;
int max = 100;
int guess ;
int number;
int guesses;
String response;

while( tryAgain )
{
    guess = 0;
    guesses = 0;
    response = "";
    number= random.Next(min, max + 1);
    

    while (guess !=number)
    {
        Console.WriteLine($"Guess a number between {min} and {max}");
        guess = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine($"Guess: {guess} ");

        if ( guess > number )
        {
            Console.WriteLine(guess + " is too high!");
        }
        else if ( guess < number ) 
        {
            Console.WriteLine(guess+ " is too low!");
        }
        guesses++;
    }
    Console.WriteLine($"Number: {number}");
    Console.WriteLine("\aYOU WIN !!!");
    Console.WriteLine($"Guesses: {guesses}");

    Console.WriteLine("Would you like to play again? (Yes/No)");
    response = Console.ReadLine();
    response = response.ToLower();

    if (response == "yes")
    { 
        tryAgain = true;
    }
    else
    {
        tryAgain= false;
    }
}

Console.WriteLine("Thanks for playing !");