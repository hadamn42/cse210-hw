using System.IO;
using System.Collections.Generic;

public class ListingActivity : Activity {

    private int _count;
    private List<string> _entries = new List<string>();

    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description){
         _name = name;
        _description = description;
    }

    public void Run(){
        int spinnerSeconds = 3;
        _entries = new List<string>();
        _count = 0;
        
        DisplayStartingMessage();
        ShowSpinner(spinnerSeconds);
        Console.WriteLine("How long would you like this session (in seconds)?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready.");        
        ShowSpinner(spinnerSeconds);
        
        DateTime theCurrentTime = DateTime.Now;
        string entryDate = theCurrentTime.ToShortDateString();
        _entries.Add(entryDate);

        string prampty = GetRandomPrompt();
        _entries.Add(prampty);
        Console.WriteLine($"\n--{prampty}--\n");
        Console.Write("You may begin in");
        int colty = 4;
        ShowCountdown(colty);
        Console.WriteLine("\n");

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            _entries.Add(Console.ReadLine());
            _count++;
            currentTime = DateTime.Now;
        }
        ShowSpinner(spinnerSeconds);
        SaveToFile();

        Console.WriteLine($"Amazing! You thought of {_count} of things in {_duration} seconds!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt(){
        Random r = new Random();
        int rInt = r.Next(0, _prompts.Count());
        return _prompts[rInt];        
    }

    private void SaveToFile()
    {
        string sessionEntry = $"{_entries[0]}";
        for (int i = 1; i < _entries.Count; i++)
        {
            sessionEntry = $"{sessionEntry} | {_entries[i]}";
            
        }
        File.AppendAllLines("ListingAnswers.txt", new[] {sessionEntry});
    }

}