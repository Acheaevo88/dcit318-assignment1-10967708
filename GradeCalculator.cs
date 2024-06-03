using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your numerical grade (between 0 and 100):");
        int grade = Convert.ToInt32(Console.ReadLine());

        char letterGrade = GetLetterGrade(grade);
        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }

    static char GetLetterGrade(int grade)
    {
        if (grade >= 90)
            return 'A';
        else if (grade >= 80)
            return 'B';
        else if (grade >= 70)
            return 'C';
        else if (grade >= 60)
            return 'D';
        else if (grade < 60)
            return 'F';
    }
}
