using System;
class Calculation
{
    private string calculationLine;
    public string CalculationLine 
    {
        get { return calculationLine; }
    }
    public void SetCalculationLine(string newLine)
    {
        calculationLine = newLine;
    }
    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }
    public string GetCalculationLine()
    {
        return calculationLine;
    }
    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            return calculationLine[calculationLine.Length - 1];
        }
        return '\0'; // Returning null character if the string is empty
    }
    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
}
class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine("10 + 5");
        Console.WriteLine($"Calculation Line: {calc.GetCalculationLine()}");
        calc.SetLastSymbolCalculationLine('=');
        Console.WriteLine($"Updated Calculation Line: {calc.GetCalculationLine()}");
        Console.WriteLine($"Last Symbol: {calc.GetLastSymbol()}");
        calc.DeleteLastSymbol();
        Console.WriteLine($"Updated Calculation Line after deleting last symbol: {calc.GetCalculationLine()}");
    }
}