using System.Xml.Schema;

public class Scripture{
    private Reference _reference;
    private bool _isAllHidden = false;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text){
        _reference = Reference;
        // build reference
        string[] textuals = text.Split(" ");
        foreach (string tixt in textuals){
            Word toxt = new Word(tixt);
            _words.Add(toxt);
        }
    }
    
    public void HideRandomWords(int numberToHide){
        //take the number of words given, select a random number of words, evaluate whether they are already hidden, if not then hide
        Random r = new Random();
        // Console.WriteLine(_words.Count);
        int total = _words.Count;
        for (int i = 0; i < numberToHide; i++){
            int rInt = r.Next(0, total);
            if (_words[rInt].IsHidden() == false){
                _words[rInt].Hide();
            }
            else{
                i--;
            }
        }
    }

    public string GetDisplayText(){
        string displayText = "";
        foreach (Word word in _words){
            if (word.IsHidden() == true){
                string ward = word.GetDisplayText();
                for (int x = 0; x < ward.Length; x++)
                {
                    displayText = displayText + "_";
                }
                displayText = displayText + " ";            
            }
            else{
                displayText = displayText + $"{word.GetDisplayText()} ";
            }
        }
        displayText = $"{_reference.GetDisplayText()}\n" + displayText;
        return displayText;
    }

    public bool AllDone(){

        int totalHidden = HiddenCount();
        
        if (totalHidden == _words.Count){
            _isAllHidden = true;
            return _isAllHidden;
        }
        else{
            _isAllHidden = false;
            return _isAllHidden;
        }
        
    }

    public bool EnoughHide(int inpat){
        bool proceed;
        int totalHidden = HiddenCount();
        int visible;
        
        visible = _words.Count - totalHidden;
        if (inpat <= visible){
            proceed = true;
            return proceed;
        }
        else{
            proceed = false;
            return proceed;
        }        
    }

    private int HiddenCount(){
        int totalHidden = 0;
        foreach (Word wird in _words){
            if (wird.IsHidden() == true){
                totalHidden++;
            }
        }
        return totalHidden;
    }
}
