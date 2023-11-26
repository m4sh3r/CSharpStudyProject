int finalScore = 0;

static void SetRandom(out int firstNumber, out int secondNumber)
{
    var random = new Random();
    firstNumber = random.Next(1, 9);
    secondNumber = random.Next(1, 9);
}

Menu();

void Menu()
{
    while(true)
    {
        string? userSelected = UserInput();

        switch (userSelected?.Trim().ToUpper())
        {
            case "A":
                AdditionGame("Addition Game Selected");
                break;
            case "S":
                SubtractionGame("Subtraction Game Selected");
                break;
            case "M":
                MultiplicationGame("Multiplication Game Selected");
                break;
            case "D":
                DivisionGame("Division Game Selected");
                break;
            case "Q":
                Console.WriteLine($"Your final score is {finalScore}");
                Console.WriteLine("Exit Program");
                Environment.Exit(1);

                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    
}

string? UserInput()
{
    Console.WriteLine(@$"Select math game you want to play: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
    Console.WriteLine("-----------------------");
    var userSelected = Console.ReadLine();
    return userSelected;
}

void AdditionGame(String message)
{
    Console.WriteLine(message);
    int firstNumber, secondNumber;
    SetRandom(out firstNumber, out secondNumber);
    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine();

    if (result != null && int.Parse(result) == firstNumber + secondNumber)
    {
        Console.WriteLine("Your answer was correct!");
        finalScore++;
    }
    else
    {
        Console.WriteLine("Your answer was wrong!");
    }
}

void SubtractionGame(String message)
{
    Console.WriteLine(message);
    int firstNumber, secondNumber;
    SetRandom(out firstNumber, out secondNumber);
    Console.WriteLine($"{firstNumber} - {secondNumber}");
    var result = Console.ReadLine();

    if (result != null && int.Parse(result) == firstNumber - secondNumber)
    {
        Console.WriteLine("Your answer was correct!");
        finalScore++;
    }
    else
    {
        Console.WriteLine("Your answer was wrong!");
    }
}

void MultiplicationGame(String message)
{
    Console.WriteLine(message);
    int firstNumber, secondNumber;
    SetRandom(out firstNumber, out secondNumber);
    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine();

    if (result != null && int.Parse(result) == firstNumber * secondNumber)
    {
        Console.WriteLine("Your answer was correct!");
        finalScore++;
    }
    else
    {
        Console.WriteLine("Your answer was wrong!");
    }
}

void DivisionGame(String message)
{
    Console.WriteLine(message);
    int firstNumber, secondNumber;
    SetRandom(out firstNumber, out secondNumber);
    Console.WriteLine($"{firstNumber} / {secondNumber}");
    var result = Console.ReadLine();

    if (result != null && int.Parse(result) == firstNumber / secondNumber)
    {
        Console.WriteLine("Your answer was correct!");
        finalScore++;
    }
    else
    {
        Console.WriteLine("Your answer was wrong!");
    }
}
