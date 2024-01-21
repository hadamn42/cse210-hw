// moved the prompts to a txt file. added in functionality to add more prompts to the .txt file. And added functionality to the PromptGenerator class to 
// ensure that the added prompts can be used in the random prompt generator
using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {  
        Journal intro = new Journal();
        PromptGenerator newtPrompt = new PromptGenerator();
        newtPrompt.CreatePomptList(); 
        int userResp = 0;

        do
        {
            Console.WriteLine(@"Please select one of the following choices:
1. Write a journal entry
2. Display all entries
3. Load journal
4. Save journal
5. Add a new prompt
6. Quit");
            string userResponse = Console.ReadLine();
            userResp = int.Parse(userResponse);

                
                if (userResp == 1)
                {
                    Entry newtEntry = new Entry();

                    DateTime theCurrentTime = DateTime.Now;
                    newtEntry._date = theCurrentTime.ToShortDateString();
                    
                    
                    newtEntry._promptText = newtPrompt.GetRandomPrompt();
                    Console.WriteLine($"{newtEntry._promptText}");

                    newtEntry._entryText = Console.ReadLine();

                    intro.AddEntry(newtEntry);                                       
                }
                else if (userResp == 2)
                {
                    intro.DisplayAll();
                }
                else if (userResp ==3)
                {
                    Console.WriteLine("Please provide the file name: ");
                    string fileName = Console.ReadLine();
                    intro.LoadFromFile(fileName);
                }
                else if (userResp == 4)
                {
                    Console.WriteLine("Please provide the file name: ");
                    string fileName = Console.ReadLine();
                    intro.SaveToFile(fileName);
                }
                else if (userResp == 5)
                {
                    newtPrompt.PrintPromptList();
                    Console.WriteLine("Please provide the new promt: ");
                    string newlPrompt = Console.ReadLine();
                    newtPrompt.AddPrompt(newlPrompt);
                }
            } while  (userResp != 6);

    }
}