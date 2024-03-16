using System;
class Counter
{
    private int value;
    public Counter()
    {
        value = 0; // Default value
    }
    public Counter(int startValue)
    {
        value = startValue; // Arbitrary value
    }
    public int Value
    {
        get { return value; }
    }
    public void Increment()
    {
        value++;
    }
    public void Decrement()
    {
        value--;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter a starting value for the counter: ");
        int startValue = Convert.ToInt32(Console.ReadLine());
        Counter counter = new Counter(startValue);
        Console.WriteLine("\nCounter - Initial Value: " + counter.Value);
        Console.WriteLine("\nIncrementing the Counter...");
        counter.Increment();
        Console.WriteLine("Counter Value after Increment: " + counter.Value);
        Console.WriteLine("\nDecrementing the Counter...");
        counter.Decrement();
        Console.WriteLine("Counter Value after Decrement: " + counter.Value);
    }
  }