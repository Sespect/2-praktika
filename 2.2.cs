using System;
class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }
    public Train(string destination, int trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Train Information:");
        Console.WriteLine($"Destination: {Destination}");
        Console.WriteLine($"Train Number: {TrainNumber}");
        Console.WriteLine($"Departure Time: {DepartureTime.ToString("hh:mm tt")}");
    }
}
class Program
{
    static void Main()
    {
        Train train1 = new Train("New York", 1234, new DateTime(2022, 10, 15, 8, 30, 0));
        Train train2 = new Train("Chicago", 5678, new DateTime(2022, 10, 16, 10, 15, 0));
        Console.WriteLine("Enter the train number to display information:");
        int inputTrainNumber = int.Parse(Console.ReadLine());
        if (inputTrainNumber == train1.TrainNumber)
        {
            train1.DisplayInfo();
        }
        else if (inputTrainNumber == train2.TrainNumber)
        {
            train2.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Train information not found for the provided train number.");
        }
    }
}