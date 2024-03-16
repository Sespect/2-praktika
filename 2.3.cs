using System;
class NumberHandler
{
    private int number1;
    private int number2;
    public int Number1 
    {
        get { return number1; }
        set { number1 = value; }
    }
    public int Number2 
    {
        get { return number2; }
        set { number2 = value; }
    }
    public void DisplayNumbers()
    {
        Console.WriteLine($"Number 1: {number1}");
        Console.WriteLine($"Number 2: {number2}");
    }
    public void ChangeNumbers(int newNumber1, int newNumber2)
    {
        Console.Write("Do you want to change the numbers? (yes/no): ");
        string response = Console.ReadLine();
        if (response.ToLower() == "yes")
        {
            Console.WriteLine("Enter new numbers:");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers changed successfully!");
        }
        else
        {
            Console.WriteLine("Numbers remain unchanged.");
        }
    }
    public int CalculateSum()
    {
        return number1 + number2;
    }
    public int FindMax()
    {
        return Math.Max(number1, number2);
    }
}
class Program
{
    static void Main()
    {
        NumberHandler numberHandler = new NumberHandler();
        numberHandler.Number1 = 10;
        numberHandler.Number2 = 20;
        Console.WriteLine("Initial Numbers:");
        numberHandler.DisplayNumbers();
        Console.WriteLine("\nSum of Numbers: " + numberHandler.CalculateSum());
        Console.WriteLine("Maximum Number: " + numberHandler.FindMax());
        Console.WriteLine("\nChanging Numbers...");
        numberHandler.ChangeNumbers(30, 40);
        Console.WriteLine("\nUpdated Numbers:");
        numberHandler.DisplayNumbers();
        Console.WriteLine("\nSum of Numbers: " + numberHandler.CalculateSum());
        Console.WriteLine("Maximum Number: " + numberHandler.FindMax());
    }
}