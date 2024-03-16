using System;
using System.Collections.Generic;
class Program 
{
    static List<List<int>> FindCombinations(int[] candidates, int target) 
  {
        var result = new List<List<int>>();
        Array.Sort(candidates);

        void Backtrack(int start, List<int> path, int target) 
      {
            if (target == 0) 
          {
                result.Add(new List<int>(path));
                return;
            }
            if (target < 0) 
          {
                return;
            }

            for (int i = start; i < candidates.Length; i++) 
          {
                if (i > start && candidates[i] == candidates[i - 1]) 
              {
                    continue;
                }
                path.Add(candidates[i]);
                Backtrack(i + 1, path, target - candidates[i]);
                path.RemoveAt(path.Count - 1);
            }
        }

        Backtrack(0, new List<int>(), target);
        return result;
    }

static void Main() 
  {
      int[] candidates1 = { 2, 5, 2, 1, 2 };
      int target1 = 5;
      foreach (var comb in FindCombinations(candidates1, target1)) 
    {
          Console.WriteLine($"[{string.Join(",", comb)}]");
      }
      int[] candidates2 = { 10, 1, 2, 7, 6, 1, 5 };
      int target2 = 8;
      foreach (var comb in FindCombinations(candidates2, target2)) 
    {
          Console.WriteLine($"[{string.Join(",", comb)}]");
      }
  }
}