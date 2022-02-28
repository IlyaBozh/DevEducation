using System;

namespace HomeWorkVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            DivisionWithRemainder();
            Console.WriteLine("Task 2");
            CalculatingExpression();
            Console.WriteLine("Task 3");
            ExchangeVariableValues();
            Console.WriteLine("Task 4");
            SolvingLinearEquation();
            Console.WriteLine("Task 5");
            DerivationEquationStraightLine();
        }

        static void DivisionWithRemainder()
        {
            Console.Write("Enter the divisible: ");
            int divisible = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("Warning!!! Division by 0");
            }
            else
            {
                Console.WriteLine($"Division result: {divisible / divisor}");
                Console.WriteLine($"The remainder of the division: {divisible % divisor}");
            }
        }

        static void CalculatingExpression()
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine("Warning!!! Division by 0");
            }
            else
            {
                int result = (int)(5 * number1 + Math.Pow(number2, 2)) / (number2 - number1);
                Console.Write("Calculation result:");
                Console.WriteLine($"(5 * {number1} + {number2}^2) / ({number2} - {number1}) = {result}");
            }
        }

        static void ExchangeVariableValues()
        {
            Console.Write("Enter the value of the first variable: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the value of the second variable: ");
            string str2 = Console.ReadLine();
            string tmp = str1;
            str1 = str2;
            str2 = tmp;
            Console.WriteLine("HAHAHA, I swapped the values of variables, I am evil itself");
            Console.WriteLine($"The value of the first variable: {str1}");
            Console.WriteLine($"The value of the second variable: {str2}");
        }

        static void SolvingLinearEquation()
        {
            Console.Write("Enter the first term of the linear equation: ");
            double firstTerm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second term of the linear equation: ");
            double secondTerm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third term of the linear equation: ");
            double thirdTerm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Solve the equation {firstTerm} * x + {secondTerm} = {thirdTerm}");
            Console.WriteLine($"x = {(thirdTerm - secondTerm) / firstTerm}");
        }

        static void DerivationEquationStraightLine()
        {
            Console.WriteLine("Enter the coordinates of the first point:");
            Console.Write("x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the second point:");
            Console.Write("x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The equation of a straight line passing through two points has the following form:");
            if (-x1 * (y2 - y1) / (x2 - x1) + y1 > 0)
            {
                Console.WriteLine($"y = {(y2 - y1) / (x2 - x1)}x + {-x1 * (y2 - y1) / (x2 - x1) + y1}");
            }
            else if (-x1 * (y2 - y1) / (x2 - x1) + y1 < 0)
            {
                Console.WriteLine($"y = {(y2 - y1) / (x2 - x1)}x - {-x1 * (y2 - y1) / (x2 - x1) + y1}");
            }
            else
            {
                Console.WriteLine($"y = {(y2 - y1) / (x2 - x1)}x");
            }
        }
    }
}
