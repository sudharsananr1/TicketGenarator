using System;

class TicketGenerator
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the Ticket Generator!");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please Enter Your Name: ");
        Console.ResetColor();
        string name = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please Enter Your Age: ");
        Console.ResetColor();
        string input = Console.ReadLine();
        int age;
        if (int.TryParse(input, out age))
        {
            string ticket = GenerateTicketByAge(age);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name : {name.ToUpper()}, Ticket : {ticket}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid age entered. {name.ToUpper()} Please enter a numeric value.");
            Console.ResetColor();
        }
    }
    static string GenerateTicketByAge(int age)
    {
        string ticketMessage;
        switch (age)
        {
            case int n when (n >= 0 && n <= 12):
                ticketMessage = "Child Ticket";
                break;
            case int n when (n >= 13 && n <= 19):
                ticketMessage = "Teen Ticket";
                break;
            case int n when (n >= 20 && n <= 59):
                ticketMessage = "Adult Ticket";
                break;
            case int n when (n >= 60):
                ticketMessage = "Senior Ticket";
                break;
            default:
                ticketMessage = "Invalid age entered.";
                break;
        }
        return ticketMessage;
    }
}
