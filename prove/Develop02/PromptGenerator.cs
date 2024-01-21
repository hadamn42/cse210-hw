using System.IO;
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> _prompts = new List<string>();

    public void CreatePomptList()
    {
        string[] lines = File.ReadAllLines("prompt.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

    public void AddPrompt(string newPromt)
    {
        _prompts.Add(newPromt);
        using (StreamWriter outputFile = new StreamWriter("prompt.txt"))
        {
            foreach (string prompt in _prompts)
            {
                outputFile.WriteLine($"{prompt}");
            }            
        }        
    }

    public void PrintPromptList()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"{prompt}");
        }
    }

    public string GetRandomPrompt()
    {
        int num = _prompts.Count;
        Random r = new Random();
        int rInt = r.Next(0, num);
        string _prompt = _prompts[rInt];
        return _prompt;
    }

}