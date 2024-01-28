//It loads from a file. and let the user select the number of words to hide.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please provide a scripture file.txt.");
        string scriptureFile = Console.ReadLine();
        char[] splitters = {' ', ':', '-'};
        string userInput = "";
        bool checkIfDone = false;

        string[] lines = File.ReadAllLines(scriptureFile);
        string reffed = lines[0];

        string[] reffedup = reffed.Split(splitters);
        int bookChap = int.Parse(reffedup[1]);
        int verseStart = int.Parse(reffedup[2]);
        int verseEnd = int.Parse(reffedup[3]);

        Reference reffal = new Reference(reffedup[0], bookChap, verseStart, verseEnd);

        Scripture scriptor = new Scripture(reffal, lines[1]);
        Console.WriteLine(scriptor.GetDisplayText());

        while (userInput != "quit")
        {
            Console.WriteLine("\nPlease provide the number of words to hide.");
            userInput = Console.ReadLine();
            int y = 0;
            bool canConvert = int.TryParse(userInput, out y);
            bool canProceed = false;
            if (canConvert == true){
                int numToHide = int.Parse(userInput);
                canProceed = scriptor.EnoughHide(numToHide);
                while(canProceed == false){
                    Console.WriteLine("That was too big. Try again.");
                    userInput = Console.ReadLine();
                    numToHide = int.Parse(userInput);
                    canProceed = scriptor.EnoughHide(numToHide);
                }
                scriptor.HideRandomWords(numToHide);
                Console.WriteLine(scriptor.GetDisplayText());                
            }
            else{
                // break;
            }
            checkIfDone = scriptor.AllDone();
            if (checkIfDone == true){
                break;
            }

        }
    }  
}