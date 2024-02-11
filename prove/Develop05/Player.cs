public class Player{
    private int _level;
    private int _exp;
    private string _title;
    private int _nextLevel;
    private List<string> _titleGrowth = new List<string>(){"Badger", "Rabbit", "Jaguar",
    "Unicorn", "Wolf", "Tiger", "Dragon", "Maticore", "Knight", "Ninja", "Naga", "Lion", "Emperor", "Fighter", 
    "Viking", "Gangster", "Rogue", "Bear", "Wizard", "Magus", "Giant", "King"};

    public Player(int level, string title, int exp){
        _level = level;
        _title = title;
        _exp = exp;
        _nextLevel = CalculateLevelThreshold(_exp);
    }

    public int GetExp(){
        return _exp;
    }

    public int GetLevel(){
        return _level;
    }

    public string GetTitle(){
        return _title;
    }

    public void GetPlayerInfo(){
        Console.WriteLine($"You are a level {GetLevel()} {GetTitle()}. You have {GetExp()} experience points. Next level up is at {_nextLevel} experience points.");
    }

    public string GetAll(){
        string line = $"{_level} | {_title} | {_exp}";
        return line;
    }

    public void LevelUp(){
        // evaluate whether to level up and then increase the level and add to the title
        if (_exp >= _nextLevel){
            ++_level;
            _nextLevel = _nextLevel + 1000;
            _title = RandomTitle() + " " + _title;
            Console.WriteLine($"Congradulations! You have leveled up! You are now a level {_level} {_title}");
        }
    }

    public void AddExperiencePoints(int points){
        _exp = _exp + points;
        Console.WriteLine($"You now have a total of {_exp} experience points!");
    }

    public string RandomTitle(){
        Random r = new Random();
        int rInt = r.Next(0, _titleGrowth.Count);
        string tittle = _titleGrowth[rInt];
        return tittle;
    }

    private int CalculateLevelThreshold(int initial){
        int diff = initial % 1000;
        int threshold = (initial - diff) + 1000;
        
        return threshold;
    }
}