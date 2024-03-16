using System;
class Student
{
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }
  
    public Student(string lastName, DateTime dateOfBirth, string groupNumber, int[] grades)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
        Grades = grades;
    }
    public void UpdateInfo(string lastName, DateTime dateOfBirth, string groupNumber)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student Information:");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Group Number: {GroupNumber}");
        Console.WriteLine("Grades:");
        for (int i = 0; i < Grades.Length; i++)
        {
            Console.WriteLine($"Grade {i + 1}: {Grades[i]}");
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student information:");
        Console.Write("Last Name: ");
      
        string lastName = Console.ReadLine();
        Console.Write("Date of Birth (yyyy-MM-dd): ");
      
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Group Number: ");
        string groupNumber = Console.ReadLine();
        Console.WriteLine("Enter grades (separated by comma): ");
        string[] gradesInput = Console.ReadLine().Split(',');
        int[] grades = Array.ConvertAll(gradesInput, int.Parse);
        Student student = new Student(lastName, dateOfBirth, groupNumber, grades);
        Console.WriteLine("\nStudent Information entered:");
        student.DisplayInfo();
        Console.WriteLine("\nDo you want to update student information? (Y/N)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
            Console.WriteLine("Select data to update:\n1. Last Name\n2. Date of Birth\n3. Group Number");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter new Last Name: ");
                    student.LastName = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Enter new Date of Birth (yyyy-MM-dd): ");
                    student.DateOfBirth = DateTime.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Enter new Group Number: ");
                    student.GroupNumber = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("\nUpdated Student Information:");
            student.DisplayInfo();
        }
    }
}