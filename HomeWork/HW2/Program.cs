using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            ArithmeticOperations();

            Console.WriteLine("Task 2");
            DefinitionQuarterCoordinatePlane();

            Console.WriteLine("Task 3");
            OutputAscendingOrder();

            Console.WriteLine("Task 4");
            SolvingQuadraticEquation();

            Console.WriteLine("Task 5");
            TranslatingNumbersIntoWrittenForm();
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

            if (number1 > number2 && number2 > number3)
                Console.WriteLine($"Numbers in ascending order: {number3} {number2} {number1}");

            else if (number1 > number2 && number3 > number2)
                Console.WriteLine($"Numbers in ascending order: {number2} {number3} {number1}");

            else if (number2 > number1 && number1 > number3)
                Console.WriteLine($"Numbers in ascending order: {number3} {number1} {number2}");

            else if (number2 > number1 && number3 > number1)
                Console.WriteLine($"Numbers in ascending order: {number1} {number3} {number2}");

            else if (number3 > number1 && number2 > number1)
                Console.WriteLine($"Numbers in ascending order: {number1} {number2} {number3}");

            else
                Console.WriteLine($"Numbers in ascending order: {number2} {number1} {number3}");
        }

        static void SolvingQuadraticEquation()
        {
            Console.Write("Enter the first coefficient of the quadratic equation: ");
            double firstCoefficient = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second coefficient of the quadratic equation: ");
            double secondCoefficient = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the free term of the quadratic equation: ");
            double freeTerm = Convert.ToDouble(Console.ReadLine());
            double discriminant = Math.Pow(secondCoefficient, 2) - 4 * firstCoefficient * freeTerm;
            Console.WriteLine($"Let 's solve a quadratic equation of the form Ax^2 + Bx + C = 0");
            Console.WriteLine($"Discriminant = {discriminant}");

            if (discriminant > 0)
            {
                Console.WriteLine("The equation has two roots:");
                Console.WriteLine($"x1 = {(-secondCoefficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient)}");
                Console.WriteLine($"x2 = {(-secondCoefficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient)}");
            }

            else if (discriminant == 0)
            {
                Console.WriteLine("The equation has one root:");
                Console.WriteLine($"x = {-secondCoefficient / (2 * firstCoefficient)}");
            }

            else
            {
                Console.WriteLine("The equation has two roots in the form of complex numbers:");
                Console.Write($"x1 = {-secondCoefficient / (2 * firstCoefficient)} + ");
                Console.WriteLine($"{(Math.Sqrt(discriminant * (-1))) / (2 * firstCoefficient)}i");
                Console.Write($"x2 = {-secondCoefficient / (2 * firstCoefficient)} - ");
                Console.WriteLine($"{(Math.Sqrt(discriminant * (-1))) / (2 * firstCoefficient)}i");
            }
        }

        static void TranslatingNumbersIntoWrittenForm()
        {
            Console.Write("Enter a number in the range from 10 to 99: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int dozen = number / 10;
            int unit = number % 10;
            string writtenFormNumbe = "";

            if (number < 20)
            {
                switch(unit)
                {
                    case 0:
                        writtenFormNumbe = "ten";
                        break;
                    case 1:
                        writtenFormNumbe = "eleven";
                        break;
                    case 2:
                        writtenFormNumbe = "twelve";
                        break;
                    case 3:
                        writtenFormNumbe = "thirteen";
                        break;
                    case 4:
                        writtenFormNumbe = "fourteen";
                        break;
                    case 5:
                        writtenFormNumbe = "fifteen";
                        break;
                    case 6:
                        writtenFormNumbe = "sixteen";
                        break;
                    case 7:
                        writtenFormNumbe = "seventeen";
                        break;
                    case 8:
                        writtenFormNumbe = "eighteen";
                        break;
                    case 9:
                        writtenFormNumbe = "nineteen";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch(dozen)
                {
                    case 2:
                        writtenFormNumbe = "twenty ";
                        break;
                    case 3:
                        writtenFormNumbe = "thirty ";
                        break;
                    case 4:
                        writtenFormNumbe = "fourty ";
                        break;
                    case 5:
                        writtenFormNumbe = "fifty ";
                        break;
                    case 6:
                        writtenFormNumbe = "sixty ";
                        break;
                    case 7:
                        writtenFormNumbe = "seventy ";
                        break;
                    case 8:
                        writtenFormNumbe = "eighty ";
                        break;
                    case 9:
                        writtenFormNumbe = "ninety ";
                        break;
                    default:
                        break;
                }

                switch (unit)
                {
                    case 1:
                        writtenFormNumbe += "one";
                        break;
                    case 2:
                        writtenFormNumbe += "two";
                        break;
                    case 3:
                        writtenFormNumbe += "three";
                        break;
                    case 4:
                        writtenFormNumbe += "four";
                        break;
                    case 5:
                        writtenFormNumbe += "five";
                        break;
                    case 6:
                        writtenFormNumbe += "six";
                        break;
                    case 7:
                        writtenFormNumbe += "seven";
                        break;
                    case 8:
                        writtenFormNumbe += "eight";
                        break;
                    case 9:
                        writtenFormNumbe += "nine";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"The written form of the number {number}: {writtenFormNumbe}");
        }
    }
}
