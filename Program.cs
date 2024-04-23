using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("Enter a number to divide each element by:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            foreach (int number in numbers)
            {
                int result = number / divisor;
                Console.WriteLine($"Result of {number} / {divisor} is {result}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        finally
        {
            Console.WriteLine("The program has completed execution.");
        }
    }
}
