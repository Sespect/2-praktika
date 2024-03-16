using System;
class Program
{
    static void Main()
    {
        string J = "ab";
        string S = "aabbccd";
        int result = CountJewelsInStones(J, S);
        Console.WriteLine(result);
    }
    static int CountJewelsInStones(string J, string S)
    {
        int count = 0;
        foreach (char stone in S)
        {
            if (J.Contains(stone))
            {
                count++;
            }
        }
        return count;
    }
}