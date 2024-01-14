using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int GradeInt = int.Parse(grade);

        if (GradeInt >= 90)
        {
            Console.WriteLine("You have an A! ");
        }
        else if (GradeInt < 90 && GradeInt >= 80)
        {
            Console.WriteLine("You have a B. ");
        }
        else if (GradeInt < 80 && GradeInt >= 70)
        {
            Console.WriteLine("You have a C. ");
        }
        else if (GradeInt < 70 && GradeInt >= 60)
        {
            Console.WriteLine("You have a D. ");
        }
        else
        {
            Console.WriteLine("You have an F. ");
        }
    }
}