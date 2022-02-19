// See https://aka.ms/new-console-template for more information
using GuessingNumberGame.Properties;

//Приветствие, считывание имени
Console.WriteLine(Resources.HelloMessage);
Console.WriteLine(Resources.NameQuestionMessage);

string? userNameInput = null;
bool isNameCorrect = false;

// Считываем имя пользователя, пока оно не будет корректным (имя не должно быть пустым, имя не должно содержать числа). 
while(!isNameCorrect)
{
    Console.ForegroundColor = ConsoleColor.White;
    userNameInput = Console.ReadLine();
    if ((userNameInput.Length == 0) || (userNameInput.Any(c => char.IsNumber(c))))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Resources.NameIsNotCorrectMessage);
    }
    else
        isNameCorrect = true;
}

userNameInput = userNameInput.Trim();
userNameInput = userNameInput.Replace("  ", " ");
string? userNumberInput = null;
string? messageIsNotCorrect = "";
bool isWin = false;
int userNumber = 0;
int minNumber  = 0;
int maxNumber  = 999;
var random = new Random();

int secretNumber = random.Next(minNumber, maxNumber);
int attemptCount = 1;

//Пока не угадали число
while(!isWin)
{
    bool isNumberCorrect = false;    
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n" +string.Format(Resources.NumberQuestionMessage, userNameInput, minNumber, maxNumber, attemptCount));

    // Считываем ввод числа пользователя, пока он не будет корректным.
    // (строка не должна быть пустой, строка должна содержать числа, числа должны попадать в диапозон minNumber...maxNumber)
    while (!isNumberCorrect)
    {
        Console.ForegroundColor = ConsoleColor.White;
        userNumberInput = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Red;

        messageIsNotCorrect = string.Format(Resources.NumberNotCorrectMessage, userNumberInput, minNumber, maxNumber);
        if ((userNumberInput.Length == 0) || (!int.TryParse(userNumberInput, out userNumber)))
            Console.WriteLine(messageIsNotCorrect);
        else
            if ((userNumber < minNumber) || (userNumber > maxNumber))
            Console.WriteLine(messageIsNotCorrect);
        else
            isNumberCorrect = true;
    }

    //Сравниваем ввод пользователя с загаданным числом
    if (userNumber > secretNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;       
        Console.WriteLine(string.Format(Resources.YourNumberMoreThanSecretMessage, userNumber));
    }

    if (userNumber < secretNumber)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(string.Format(Resources.YourNumberLessThanSecretMessage, userNumber));
    }
    if (userNumber == secretNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(string.Format(Resources.YourWinMessage, userNumber));
        isWin = true;
    }

    Console.ForegroundColor = ConsoleColor.White;
    attemptCount += 1;
}
Console.ReadLine();