using System;

class TriangleFormIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        // Prompt user for input and convert to integers
        Console.Write("Side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        // Check the type of triangle
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is an Equilateral triangle.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("The triangle is a Scalene triangle.");
        }
    }
}
