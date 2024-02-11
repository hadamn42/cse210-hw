// Added the Player class that stores the level, title, and experience points of the user. It levels the user up
// every 1000 points and adds a random new word to the title. Also changed some normal functionality to incorporate the 
// new Player class

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gilManger = new GoalManager();
        gilManger.Start();
    }
}