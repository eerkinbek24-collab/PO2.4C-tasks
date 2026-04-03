using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Exercise 1:");

        Console.Write("Enter your 1st number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your 2nd number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        { Console.WriteLine($"{num1} > {num2}"); }
        else if (num1 < num2)
        { Console.WriteLine($"{num1} < {num2}"); }
        else
        { Console.WriteLine($"{num1} = {num2}"); }


        Console.WriteLine("\nExercise 2:");
        Console.Write("Enter a number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num3 > 5 && num3 < 10)
        { Console.WriteLine("The number is greater than 5 and less than 10"); }
        else
        { Console.WriteLine("Unknown number"); }


        Console.WriteLine("\nExercise 3:");
        Console.Write("Enter a number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        if (num4 == 5 || num4 == 10)
        { Console.WriteLine("The number is either 5 or 10"); }
        else
        { Console.WriteLine("Unknown number"); }


        Console.WriteLine("\nExercise 4:");
        Console.Write("Enter deposit amount: ");
        double sum4 = Convert.ToDouble(Console.ReadLine());
        if (sum4 < 100)
        { sum4 += sum4 * 0.05; }
        else if (sum4 <= 200)
        { sum4 += sum4 * 0.07; }
        else
        { sum4 += sum4 * 0.1; }
        Console.WriteLine($"Deposit amount after interest: {sum4}");


        Console.WriteLine("\nExercise 5:");
        Console.Write("Enter deposit amount: ");
        double sum5 = Convert.ToDouble(Console.ReadLine());
        double percent = 0;
        if (sum5 < 100)
        { percent = 0.05; }
        else if (sum5 <= 200)
        { percent = 0.07; }
        else
        { percent = 0.1; }
        sum5 += sum5 * percent + 15;
        Console.WriteLine($"Deposit amount after interest and bonus: {sum5}");


        Console.WriteLine("\nExercise 6:");
        Console.Write("Enter operation number: 1.Addition  2.Subtraction  3.Multiplication: ");
        int operation6 = Convert.ToInt32(Console.ReadLine());
        switch (operation6)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("The operation is undefined");
                break;
        }


        Console.WriteLine("\nExercise 7:");
        Console.Write("Enter your 1st number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your 2nd number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter operation number: 1.Addition  2.Subtraction  3.Multiplication: ");
        int operation7 = Convert.ToInt32(Console.ReadLine());


        switch (operation7)
        {
            case 1:
                Console.WriteLine($"Result: {a} + {b} = {a + b}");
                break;
            case 2:
                Console.WriteLine($"Result: {a} - {b} = {a - b}");
                break;
            case 3:
                Console.WriteLine($"Result: {a} * {b} = {a * b}");
                break;
            default:
                Console.WriteLine("The operation is undefined");
                break;
        }
        Console.ReadKey();
    }
}