// Automatically saves the Listing Activity as an entry in a file with the date of entry and the prompt.
using System;

class Program
{
    static void Main(string[] args)
    {   
        
        int menuChoice = 0;
        do{
            Console.WriteLine(@"Please select a mindfulness activity:
    1: Breathing Activity
    2: Listing Activity
    3: Reflecting Activity
    4: Quit");
            menuChoice = int.Parse(Console.ReadLine());
            
            if(menuChoice == 1){
                string name = "Breathing Activity";
                string description = @"This activity will calm your mind by focusing on breathing in and out slowly. 
Clear your mind and focus on your breathing.";
                BreathingActivity breath = new BreathingActivity (name, description);
                
                breath.Run();
            }
            else if(menuChoice == 2){
                string name = "Listing Activity";
                string description = @"This activity will help you reflect on the good things in life by having you list 
as many things as you can in a certain area.";
                ListingActivity lists = new ListingActivity(name, description);
                lists.Run();
            }
            else if(menuChoice == 3){
                string name = "Reflecting Activity";
                string description = @"This activity will have you reflect on a time in your life when you have shown strength
and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflect = new ReflectingActivity(name, description);
                reflect.Run();
            }
        }while (menuChoice != 4);
    }
}