using System;

class Program
{
    static void Main(string[] args)
    {      
        int userResp = 0;  
        do
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save \n5. Quit");
            string userResponse = Console.ReadLine();
            userResp = int.Parse(userResponse);

                Journal intro = new Journal();
                if (userResp == 1)
                {
                    Entry newtEntry = new Entry();

                    DateTime theCurrentTime = DateTime.Now;
                    newtEntry._date = theCurrentTime.ToShortDateString();
                    
                    PromptGenerator newtPropmt = new PromptGenerator();
                    newtEntry._promptText = newtPropmt.GetRandomPrompt();
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
            } while  (userResp != 5);

    }
}