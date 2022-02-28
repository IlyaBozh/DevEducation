
//Exponentiation();
//SearchDivisibleNumbers();
//FindingNumberPositiveSquaresNumbers();
//FindingLargestDivisorNumber();
//SumNumbersInRange();
SearchFibonacciNumberByNumber();






// Task 1
static void Exponentiation()
{
    Console.Write("Enter a number: ");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the degree of the number: ");
    double degreeNumber = Convert.ToDouble(Console.ReadLine());
    double tmp = 1;

    for (int i = 0; i < Math.Abs(degreeNumber); i++)
    {
        tmp = tmp * number;
    }

    if (degreeNumber < 0)
    {
        tmp = 1 / tmp;
    }

    Console.WriteLine($"A number {number} raised to a power {degreeNumber} = {tmp}");
}

// Task 2
static void SearchDivisibleNumbers()
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write($"numbers that are divisible by {number} from 1 to 1000: ");

    for (int i = number; i <= 1000; i += number)
    {
        Console.Write($"{i} ");
    }
}

// Task 3
static void FindingNumberPositiveSquaresNumbers()
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int countNumbers = 0;
   
    while (Math.Pow(countNumbers, 2) < number)
    {
        countNumbers++;
    }
    
    Console.WriteLine($"The number of numbers whose square is not more than {number} = {countNumbers - 1}");
}

// Task 4
static void FindingLargestDivisorNumber()
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int divisor = number;

    do
    {
        divisor--;
    } while (number % divisor != 0);

    Console.WriteLine($"The largest divisor of a number {number} = {divisor}");
}

// Task 5
static void SumNumbersInRange()
{
    Console.Write("Enter the left border: ");
    int leftBorder = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the right border: ");
    int rightBorder = Convert.ToInt32(Console.ReadLine());
    int SumNumbers = 0;

    if (leftBorder > rightBorder)
    {
        int tmp = leftBorder;
        leftBorder = rightBorder;
        rightBorder = tmp;
    }

    for (int i = leftBorder; i <= rightBorder; i++)
    {
        if (i % 7 == 0)
        {
            SumNumbers += i;
        }
    }

    Console.WriteLine($"The sum of the numbers that are divisible by 7 = {SumNumbers}");
}

// Task 6
static void SearchFibonacciNumberByNumber()
{
    Console.Write("Enter the number of the Fibonacci number: ");
    int serialNumber = Convert.ToInt32(Console.ReadLine());

    int firstNumber = 1;
    int secondNumber = 1;
    int thirdNumber = 1;

    for (int i = serialNumber; i > 2; i--)
    {
        thirdNumber = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = thirdNumber;
    }

    Console.WriteLine($"The number of the Fibonacci series under the number {serialNumber} = {thirdNumber}");
}