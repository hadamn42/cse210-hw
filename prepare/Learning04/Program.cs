using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment Jeff = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "8-19");

        var hwHeader = Jeff.GetHomeworkList();

        Console.WriteLine($"{hwHeader.Item1} - {hwHeader.Item2}\n{hwHeader.Item3} Problems {hwHeader.Item4}\n");
        
        WritingAssignment Mary = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        var engHeader = Mary.GetWritingInformation();

        Console.WriteLine($"{engHeader.Item1} - {engHeader.Item2}\n{engHeader.Item3} by {engHeader.Item1}");
    }
}