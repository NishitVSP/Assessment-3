using System;

public class Class2
{
    static long Factorial(int n)
    {
        if (n <= 1)  return 1; 
        return n * Factorial(n - 1);
    }
    public static void loop()
	{
        // Uses a for loop to print numbers from 1 to 10.
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Uses a while loop to keep asking the user for input until they enter exit.
        string input;
        do{
            Console.Write("Enter something (type 'exit' to quit): ");
            input = Console.ReadLine();
        } while (input.ToLower() != "exit");

        //  Defines and calls a function that calculates the factorial of a number provided by the user. 
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
    }
}

