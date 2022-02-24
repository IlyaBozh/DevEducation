using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            ArithmeticOperations();
        }

        static void ArithmeticOperations()
        {
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            if (number1 > number2)
                Console.WriteLine($"Let's add these two numbers: A + B = {number1 + number2}");
            else if (number1 < number2)
                Console.WriteLine($"Subtract the second from the first number: A - B = {number1 - number2}");
            else
                Console.WriteLine($"Multiply these two numbers: A * B = {number1 * number2}");
        }
    }
}
