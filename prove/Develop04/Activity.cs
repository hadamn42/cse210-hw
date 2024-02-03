public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;
        
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage(){
        Console.WriteLine($"\nCongradulations! You've completed another {_duration} seconds of the {_name}!\n");
        int spinnerSeconds = 4;
        ShowSpinner(spinnerSeconds);
    }

    public void ShowSpinner(int seconds){
        int i;
        for(i = -1; i < seconds; i++){
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("--");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
    }

    public void ShowCountdown(int count){
        Console.Write("...");
        for(int i = count; i > 0; i--){
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b \b"); 
        }
        
    }
}