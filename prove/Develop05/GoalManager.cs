using System.IO;
using System.Collections.Generic;

public class GoalManager{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private List<Player> _players = new List<Player>();
    private int _playerInput = 0;

    public void Start(){
         Player newPlayer = new Player(0, "", 0);
        _players.Add(newPlayer);

        while(_playerInput != 8){
            if (_players[0].GetLevel() == 0){
                Console.Write("Please load a file or create a new player class");
            }
            else{
            Console.Write(@$"You have {_score} experience points.");
            }

            Console.WriteLine(@$"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Player Status
    4. Save Goals
    5. Load Goals
    6. Record Event
    7. Reset/New Player
    8. Quit
Select a choice from the menu: ");
            _playerInput = int.Parse(Console.ReadLine());
            if (_playerInput == 1){
                CreateGoal();
            }
            else if(_playerInput == 2){
                ListGoalDetails();
            }
            else if(_playerInput == 3){
                DisplayPlayerInfo();
            }
            else if(_playerInput == 4){
                Console.WriteLine("File name: ");
                string file = Console.ReadLine();
                SaveGoals(file);
            }
            else if(_playerInput == 5){
                Console.WriteLine("File name: ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }
            else if(_playerInput == 6){
                RecordEvent();
            }
            else if(_playerInput == 7){
                Player titleGet = new Player(0, "", 0);
                Player reset = new Player(1, titleGet.RandomTitle(), 0);
                _players[0] = reset;
            }
        _score = _players[0].GetExp();
        }
    }

    private void DisplayPlayerInfo(){
        _players[0].GetPlayerInfo();
    }

    private void ListGoalNames(){
        foreach(Goal goal in _goals){
            int i = 1 + _goals.IndexOf(goal);
            Console.WriteLine($"{i}. {goal.GetName()}");
        }
    }

    private void ListGoalDetails(){
        foreach(Goal goal in _goals){
            int i = 1 + _goals.IndexOf(goal);
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
    }

    private void CreateGoal(){
        int response = 42;
        do{
            Console.WriteLine(@"Provide the goal type's number:
    1. Simple
    2. Eternal
    3. Checklist");
            response = int.Parse(Console.ReadLine());

            if(response == 1){
                string typeO = "simgol";
                Console.WriteLine("Name your goal: ");
                string nameO = Console.ReadLine();
                Console.WriteLine("Describe your goal: ");
                string describeO = Console.ReadLine();
                Console.WriteLine("How many experience points will you earn when you complete this goal?");
                int pointO = int.Parse(Console.ReadLine());
                SimpleGoal goul = new SimpleGoal(nameO, describeO, pointO, typeO);
                _goals.Add(goul);

            }
            else if(response == 2){
                string typeO = "etgol";
                Console.WriteLine("Name your goal: ");
                string nameO = Console.ReadLine();
                Console.WriteLine("Describe your goal: ");
                string describeO = Console.ReadLine();
                Console.WriteLine("Enter the amount of experience points will you earn each time you do this?");
                int pointO = int.Parse(Console.ReadLine());
                EternalGoal goul = new EternalGoal(nameO, describeO, pointO, typeO);
                _goals.Add(goul);
            }
            else if(response == 3){
                string typeO = "checkgol";
                Console.WriteLine("Name your goal: ");
                string nameO = Console.ReadLine();
                Console.WriteLine("Describe your goal: ");
                string describeO = Console.ReadLine();
                Console.WriteLine("Enter the amount of experience points will you earn each time you do this:");
                int pointO = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the target number to receive bonus experience points:");
                int targetO = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount of bonus experience point you will receive when you reach that target:");
                int bonusO = int.Parse(Console.ReadLine());
                ChecklistGoal goul = new ChecklistGoal(nameO, describeO, pointO, typeO, targetO,bonusO, 0);
                _goals.Add(goul);
            }
        }while(response > 3);
    }

    private void RecordEvent(){
        ListGoalNames();
        int userInput = int.Parse(Console.ReadLine()) - 1;
        int pointy = _goals[userInput].RecordEvent();
        Console.WriteLine($"Congradulations! You earned {pointy} experience points!");
        _players[0].AddExperiencePoints(pointy);
        _players[0].LevelUp();
    }
    
    private void SaveGoals(string fileName){              
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Player pill in _players)
            {
                string line = pill.GetAll();
                outputFile.WriteLine($"{line}");
            }
            foreach (Goal gloat in _goals)
            { 
                string loon = gloat.GetStringRepresentation();
                outputFile.WriteLine($"{loon}");
            }           
        }
    }

    private void LoadGoals(string fileName){
        string[] lines = File.ReadAllLines(fileName);
        string[] hero = lines[0].Split(" | ");
        Player pal = new Player(int.Parse(hero[0]), hero[1], int.Parse(hero[2]));
        _players[0] = pal;
        _score = int.Parse(hero[2]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(" | ");
            if(parts[0] == "simgol"){                
                SimpleGoal spimple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[0]);
                _goals.Add(spimple);
            }
            else if(parts[0] == "etgol"){
                EternalGoal entGol = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), parts[0]);
                _goals.Add(entGol);
            }
            else if(parts[0] == "checkgol"){
                ChecklistGoal cheekygol = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), parts[0], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(cheekygol);
            }          
        }
    }
}