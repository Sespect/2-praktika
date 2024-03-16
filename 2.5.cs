using System;
class Pelmeni
{
    public int Quantity { get; set; }
    public int Size { get; set; }
    public Pelmeni(int quantity, int size)
    {
        Quantity = quantity;
        Size = size;
    }
    public Pelmeni()
    {
        Quantity = 0;
        Size = 0;
    }
    ~Pelmeni()
    {
        Console.WriteLine("Object of Pelmeni has been deleted.");
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter the quantity for Pelmeni: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the size for Pelmeni: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Pelmeni pelmeni1 = new Pelmeni(quantity, size); 
        Pelmeni pelmeni2 = new Pelmeni();
        Console.WriteLine("\nPelmeni 1 - Quantity: " + pelmeni1.Quantity + ", Size: " + pelmeni1.Size);
        Console.WriteLine("Pelmeni 2 (default values) - Quantity: " + pelmeni2.Quantity + ", Size: " + pelmeni2.Size);
        Console.WriteLine("\nProgram has finished executing.");
    }
}