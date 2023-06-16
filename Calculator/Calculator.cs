using System;
using System.Collections.Generic;
namespace Calculator
{
    public static class CalculatorStart
    {
        public static void RunCalculator()
        {


            Console.WriteLine("Calculator");
            Console.WriteLine("------------");
            Console.WriteLine("Enter First Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ente: + , - , * , / , % ,");
            char Symbol = Convert.ToChar(Console.ReadLine());
       


            double result = 0;

            switch (Symbol)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            
            

        }
    }
}