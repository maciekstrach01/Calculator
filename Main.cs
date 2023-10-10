using System;

namespace CalculatorApp
{
class Program
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Number of calls to the Add method");
                Console.WriteLine("4. Number of calls to the Subtract method");
                Console.WriteLine("5. Finish");
                Console.WriteLine("Select the option:");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter the first number:");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            Console.WriteLine("An incorrect number has been entered.");
                            continue;
                        }

                        Console.WriteLine("Enter the second number:");
                        if (!double.TryParse(Console.ReadLine(), out double b))
                        {
                            Console.WriteLine("An incorrect number has been entered.");
                            continue;
                        }

                        Console.WriteLine($"Result: {CalculatorApp.Calculator.Add(a, b)}");
                        break;
                    case "2":
                        Console.WriteLine("Enter the first number:");
                        if (!double.TryParse(Console.ReadLine(), out double c))
                        {
                            Console.WriteLine("An incorrect number has been entered.");
                            continue;
                        }

                        Console.WriteLine("Enter the second number:");
                        if (!double.TryParse(Console.ReadLine(), out double d))
                        {
                            Console.WriteLine("An incorrect number has been entered.");
                            continue;
                        }

                        Console.WriteLine($"Result: {CalculatorApp.Calculator.Subtract(c, d)}");
                        break;
                    case "3":
                        Console.WriteLine($"Number of calls to the Add method: {CalculatorApp.Calculator.NumberCallAdd}");
                        break;
                    case "4":
                        Console.WriteLine($"Number of calls to the Subtract method: {CalculatorApp.Calculator.NumberCallSubtract}");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Unknown option.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error has occurred: {ex.Message}");
        }
    }
}

}

