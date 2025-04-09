using System;
public class Class1
{
    public static void operations()
    {

        // Activity 5: Basic Syntax and Control Structures
        try
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
                
            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero!");

            double quotient = (double)num1 / num2;
            Console.WriteLine($"Quotient: {quotient}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numeric values.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
