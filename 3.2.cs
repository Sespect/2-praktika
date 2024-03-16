using System;
class Worker
{
    private string Name { get; }
    private string Surname { get; }
    private double Rate { get; }
    private int Days { get; }
    public Worker(string name, string surname, double rate, int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }
    public string GetName()
    {
        return Name;
    }
    public string GetSurname()
    {
        return Surname;
    }
    public double GetRate()
    {
        return Rate;
    }
    public int GetDays()
    {
        return Days;
    }
    public double GetSalary()
    {
        return Rate * Days;
    }
}
class Program
{
    static void Main()
    {
        Worker worker = new Worker("John", "Doe", 10.0, 20);
        Console.WriteLine($"Salary: {worker.GetSalary()}");
    }
}