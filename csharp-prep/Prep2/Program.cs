using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type your grade percentage: ");

        string gradeFromUser = Console.ReadLine();
        int grade = int.Parse(gradeFromUser);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("You failed. Don't give up and try again!");
        }
    }
}
