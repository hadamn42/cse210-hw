public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description) : base(name, description){
        _name = name;
        _description = description;
       
    }
    
    public void Run(){
        int spinnerSeconds = 3;
        DisplayStartingMessage();
        ShowSpinner(spinnerSeconds);
        Console.WriteLine("How long would you like this session (in seconds)?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready.");        
        ShowSpinner(spinnerSeconds);
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            int broth = 4;
            Console.Write("Breathe In");
            ShowCountdown(broth);
            Console.Write("\nHold your breath");
            broth = 7;
            ShowCountdown(broth);            
            Console.Write("\nBreathe out");
            broth = 8;
            ShowCountdown(broth);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }
}
