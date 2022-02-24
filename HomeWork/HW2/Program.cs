using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            Console.WriteLine("Task 1");
            ArithmeticOperations();
            Console.WriteLine("Task 2");
            DefinitionQuarterCoordinatePlane();*/
            Console.WriteLine("Task 3");
            OutputAscendingOrder();
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

        static void DefinitionQuarterCoordinatePlane()
        {
            Console.WriteLine("Enter the coordinates of the point:");
            Console.Write("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x == 0 && y == 0)
                Console.WriteLine("The point lies at the origin of the coordinates");
            else if (x == 0)
                Console.WriteLine("The point lies on the x axis");
            else if (y == 0)
                Console.WriteLine("The point lies on the y axis");
            else if (x > 0 && y > 0)
                Console.WriteLine("The point belongs to the first quarter of the coordinate plane");
            else if (x < 0 && y > 0)
                Console.WriteLine("The point belongs to the second quarter of the coordinate plane");
            else if (x < 0 && y < 0)
                Console.WriteLine("The point belongs to the third quarter of the coordinate plane");
            else
                Console.WriteLine("The point belongs to the fourth quarter of the coordinate plane");
        }

        static void OutputAscendingOrder()
        {
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                if (number2 > number3)
                    Console.WriteLine($"Numbers in ascending order: {number3} {number2} {number1}");
                else
                    Console.WriteLine($"Numbers in ascending order: {number2} {number3} {number1}");
            }
            else if (number2 > number1 && number2 > number3)
            {
                if (number1 > number3)
                    Console.WriteLine($"Numbers in ascending order: {number3} {number1} {number2}");
                else
                    Console.WriteLine($"Numbers in ascending order: {number1} {number3} {number2}");
            }
            else
            {
                if (number1 > number2)
                    Console.WriteLine($"Numbers in ascending order: {number2} {number1} {number3}");
                else
                    Console.WriteLine($"Numbers in ascending order: {number1} {number2} {number3}");
            }
        }
    }
}

