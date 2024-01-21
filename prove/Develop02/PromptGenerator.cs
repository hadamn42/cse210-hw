public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was my greatest blessing today?",
        "How did I help my wife today?",
        "What did I learn from the scriptures today?"
    };

    public string GetRandomPrompt()
    {
        Random r = new Random();
        int rInt = r.Next(0, 7);
        string _prompt = _prompts[rInt];
        return _prompt;
    }

}