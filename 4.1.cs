using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine(RomanToInt("III"));      // Output: 3
        Console.WriteLine(RomanToInt("LVIII"));    // Output: 58
        Console.WriteLine(RomanToInt("MCMXCIV"));  // Output: 1994
    }
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int total = 0;
        int prevValue = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int curValue = romanValues[s[i]];
            if (curValue < prevValue)
            {
                total -= curValue;
            }
            else
            {
                total += curValue;
            }
            prevValue = curValue;
        }
        return total;
    }
}