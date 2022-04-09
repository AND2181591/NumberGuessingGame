

var randomNum = new Random();
var lowNum = 0;
var highNum = 100;

int winNum = randomNum.Next(lowNum, highNum);
bool win = false;

do
{
    Console.WriteLine($"Guess a number between {lowNum} and {highNum}");
    string? guess = Console.ReadLine();

    while (!int.TryParse(guess, out _))
    {
        Console.WriteLine("Sorry, a number needs to be entered.");
        Console.WriteLine($"Guess a number between {lowNum} and {highNum}");
        guess = Console.ReadLine();
    }

    int i = int.Parse(guess);
    if (i < winNum)
    {
        Console.WriteLine("Sorry, that number is too low");
    } 
    else if (i > winNum)
    {
        Console.WriteLine("Sorry, that number is too high");
    }
    else if (i == winNum)
    {
        Console.WriteLine("YOU WIN!!");
        win = true;
    }

    Console.WriteLine();
} while (win == false);

Console.WriteLine("Thank you for playing!");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();