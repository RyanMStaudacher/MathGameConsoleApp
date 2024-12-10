using System.Net;

bool gameShouldRun = true;
List<string> gameHistory = new List<string>();

do
{
    MathGameFunction();
}while(gameShouldRun);


void MathGameFunction()
{
    Console.WriteLine("Hello! Welcome to Ryan's Miraculous Math Game!!\nPlease choose an operation to perform:\n\n:Addition:\n:Subtraction:\n:Multiplication:\n:Division:\n:Past Games:\n:Quit Game:\n");
    string operationChoice = Console.ReadLine();

    switch (operationChoice)
    {
        case "addition":
        AdditionFunction();
        break;
        case "subtraction":
        SubtractionFunction();
        break;
        case "multiplication":
        MultiplicationFunction();
        break;
        case "division":
        DivisionFunction();
        break;
        case "past games":
        PastGamesFunction();
        break;
        case "quit game":
        QuitGame();
        break;
    }
}

void AdditionFunction()
{
    Console.WriteLine("Please input any number.\n");
    int num1 = 0;
    Int32.TryParse(Console.ReadLine(), out num1);
    Console.WriteLine("Please input the number to add to " + num1);
    int num2 = 0;
    Int32.TryParse(Console.ReadLine(), out num2);
    int sum = num1 + num2;
    string answer = "The sum of " + num1 + " and " + num2 + " is " + sum + ".";
    Console.WriteLine(answer);
    gameHistory.Add(answer);
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
}

void SubtractionFunction()
{
    Console.WriteLine("Please input any number.\n");
    int num1 = 0;
    Int32.TryParse(Console.ReadLine(), out num1);
    Console.WriteLine("Please input the number to subtract from " + num1);
    int num2 = 0;
    Int32.TryParse(Console.ReadLine(), out num2);
    int difference = num1 - num2;
    string answer = "The difference of " + num1 + " and " + num2 + " is " + difference + ".";
    Console.WriteLine(answer);
    gameHistory.Add(answer);
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
}

void MultiplicationFunction()
{
    Console.WriteLine("Please input any number.\n");
    int num1 = 0;
    Int32.TryParse(Console.ReadLine(), out num1);
    Console.WriteLine("Please input the number to multiply with " + num1);
    int num2 = 0;
    Int32.TryParse(Console.ReadLine(), out num2);
    int product = num1 * num2;
    string answer = "The product of " + num1 + " and " + num2 + " is " + product + ".";
    Console.WriteLine(answer);
    gameHistory.Add(answer);
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
}

void DivisionFunction()
{
    int num1 = 0;
    int num2 = 0;
    int moduloResult = 0;

    do
    {
        do
        {
            Console.WriteLine("Please input any number.\n");
            Int32.TryParse(Console.ReadLine(), out num1);
            if(num1 > 100)
            {
                Console.WriteLine("The number cannot be greater than 100.");
            }
        }while(num1 > 100);

        do
        {
            Console.WriteLine("Please input a number to divide " + num1 + " by.");
            Int32.TryParse(Console.ReadLine(), out num2);
            if(num2 > 100)
            {
                Console.WriteLine("The number cannot be greater than 100.");
            }
        }while(num2 > 100);

        moduloResult = num1%num2;

        if(moduloResult != 0)
        {
            Console.WriteLine("The quotient of the two numbers must result in an integer.");
        }
        else if(moduloResult == 0)
        {
            int quotient = num1 / num2;
            string answer = "The quotient of " + num1 + " and " + num2 + " is " + quotient;
            Console.WriteLine(answer);
            gameHistory.Add(answer);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }while(moduloResult != 0);
}

void PastGamesFunction()
{
    foreach(string a in gameHistory)
    {
        Console.WriteLine(a);
    }
    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();
}

void QuitGame()
{
    gameShouldRun = false;
}