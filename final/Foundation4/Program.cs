using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Running running1 = new Running("02/13/2024", 60, 10);
        exercises.Add(running1);

        Cycling cycling1 = new Cycling("02/14/2024", 120, 20);
        exercises.Add(cycling1);

        Swimming swimming1 = new Swimming("02/17/2024", 30, 50);
        exercises.Add(swimming1);


        foreach(Exercise exy in exercises){
            exy.Summary();
        }

    }
}