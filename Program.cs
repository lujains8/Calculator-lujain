// See https://aka.ms/new-console-template for more information
using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator!");
        
        while (true)
        {
            Console.Write("Enter first number");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter an operator (+, -, *, /): ");
            string operation = Console.ReadLine();

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero!");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator!");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input!");
            }
        }
        
    }
}