namespace StackCalculator;

using System;

class Program
{
    private static void Main()
    {
        Console.WriteLine("This program calculates expression in postfix form. " +
                          "\nEnter string you want to calculate:");
        var inputString = Console.ReadLine();
        if (inputString == null)
        {
            Console.WriteLine("Input error.");
            return;
        }
        Console.WriteLine("Enter:" +
                          "\n1 - to use stack on array," +
                          "\n2 - to use stack on list.");
        int parsedCommand;
        while (true)
        {
            var inputCommand = Console.ReadLine();
            int.TryParse(inputCommand, out parsedCommand);
            if (parsedCommand != 1 && parsedCommand != 2)
            {
                Console.WriteLine("Incorrect input! Try again:");
            }
            else
            {
                break;
            }
        }

        IStack stack = parsedCommand switch
        {
            1 => new StackArray(),
            2 => new StackList(),
        };

        var (isPrefixExpressionCorrect, result) = StackCalculator.Calculate(inputString, stack);
        if (!isPrefixExpressionCorrect)
        {
            Console.WriteLine("Entered prefix expression is incorrect.");
            return;
        }

        Console.WriteLine($"Result of calculation: {result}");
    }
}