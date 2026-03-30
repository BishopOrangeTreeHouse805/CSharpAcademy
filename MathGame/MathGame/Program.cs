Console.WriteLine("Please enter your name:");

string name =  Console.ReadLine();
DateTime date  = DateTime.UtcNow;

Console.WriteLine("---------------------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're improving yourself\n");
Console.WriteLine($@"What game would you like to play today?
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the game");
Console.WriteLine("---------------------------------------------------");

string gameSelected = Console.ReadLine();


if (gameSelected.Trim().ToUpper() == "a")
{
    AdditionGame();
}
else if (gameSelected.Trim().ToUpper() == "s")
{
    SubstractionGame();
}
else if (gameSelected.Trim().ToUpper() == "m")
{
    MultiplicationGame();
}
else if (gameSelected.Trim().ToUpper() == "d")
{
    DivisionGame();
}
else
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}


//Methods for the game
void AdditionGame()
{
    Console.WriteLine("Addition game selected");
}

void SubstractionGame()
{
    Console.WriteLine("Substraction game selected");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
}

void DivisionGame()
{
    Console.WriteLine("Division game selected");
}