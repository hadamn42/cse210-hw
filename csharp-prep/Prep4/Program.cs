using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string userNumber;
        int userNum = -1;
        int total = 0;
        int average;
        int totalIndex;
        int largest = 0;
        
        while (userNum != 0)
        {
            Console.WriteLine("Provide a number. ");
            userNumber = Console.ReadLine();
            userNum = int.Parse(userNumber);
            numbers.Add(userNum);
            if (userNum > largest)
            {
                largest = userNum;
            }
        }

        foreach (int num in numbers)
        {
            total += num;
        }

        totalIndex = numbers.Count;
        average = total/(totalIndex - 1);
        Console.WriteLine($"The sum is: {total} ");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The largest number is: {largest} ");
        Console.WriteLine($"The largest number is: {totalIndex} ");
    }
}