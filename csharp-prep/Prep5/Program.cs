using System;


class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string UserName = Console.ReadLine();

        return UserName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string numb = Console.ReadLine();
        int NumbInt = int.Parse(numb);
        
        return NumbInt;
    }

    static int SquareNumber(int numb)
    {
        int answer = numb * numb;
        return answer;
    }

    static void DisplayResult(string UserName, int Squared)
    {
        Console.WriteLine($"{UserName}, the square of your number is {Squared}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string named = PromptUserName();
        int numble = PromptUserNumber();

        int squarel = SquareNumber(numble);

        DisplayResult(named, squarel);        
    }
}