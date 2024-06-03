using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        decimal ticketPrice = CalculateTicketPrice(age);
        Console.WriteLine($"The ticket price is: GHC {ticketPrice}");
    }

    static decimal CalculateTicketPrice(int age)
    {
        decimal standardPrice = 10;
        decimal discountedPrice = 7;

        if (age >= 65 || age <= 12)
            return discountedPrice;
        else
            return standardPrice;
    }
}
