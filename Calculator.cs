using System;
namespace CalculatorApp
{
public class Calculator
{
    public static int NumberCallAdd { get; private set; }
    public static int NumberCallSubtract { get; private set; }

    public static double Add(double a, double b)
    {
        NumberCallAdd++;
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        NumberCallSubtract++;
        return a - b;
    }
}

}