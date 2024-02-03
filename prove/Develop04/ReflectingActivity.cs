public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description){
        _name = name;
        _description = description;
    }

    public void Run(){
        int spinnerSeconds = 3;
        DisplayStartingMessage();
        ShowSpinner(spinnerSeconds);
        Console.WriteLine("How long would you like this session (in seconds)?");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Get Ready. ");        
        ShowSpinner(spinnerSeconds);        
        GetRandomPrompt();
        Console.Write("Now answer the following questions");
        int colter = 4;
        ShowCountdown(colter);

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            GetRandomQuestion();
            int spinTime = 7;
            ShowSpinner(spinTime);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();

    }

    private void GetRandomPrompt(){
        Random r = new Random();
        int rInt = r.Next(0, _prompts.Count());
        string prompto = _prompts[rInt];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"-- {prompto} --");
        Console.WriteLine("Press ENTER to continue.");
        string radoSponse = Console.ReadLine();
    }

    private void GetRandomQuestion(){
        Random r = new Random();
        int rInt = r.Next(0, _prompts.Count());
        string questy = _questions[rInt];
        Console.Write($"\n\n{questy}");
    }
}