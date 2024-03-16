using System;
using System.Collections.Generic;
class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>();
        foreach (int num in nums)
        {
            if (numSet.Contains(num))
            {
                return true;
            }
            numSet.Add(num);
        }
        return false;
    }
    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 4 };
        Console.WriteLine($"nums1: {ContainsDuplicate(nums1)}");
        int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.WriteLine($"nums2: {ContainsDuplicate(nums2)}");
        int[] nums3 = { 1, 2, 3, 1 };
        Console.WriteLine($"nums3: {ContainsDuplicate(nums3)}");
    }
}