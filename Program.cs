using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Please enter a non-negative integer: ");
        }

        int result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }

    static int Factorial(int n)
    {
        int factorial = 1;
        for (int i = n; i >= 1; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
}
