using System;
using System.Collections.Generic;

namespace TwoSumFinder
{
    class MainClass
    {
        /*
         
        Two Sum - C#, ALGORITHMIC, THINKING, SEARCHING
        Function that, given a list and a target sum, returns zero-based indices of any two elements 
        whose sum is equal to the target sum. If there are no such elements, the function should return null.

        For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return a Tuple<int, int> 
        containing any of the following pairs of indices:

        1 and 4 (3 + 9 = 12)
        2 and 3 (5 + 7 = 12)
        3 and 2 (7 + 5 = 12)
        4 and 1 (9 + 3 = 12)
        
        */

        public static void Main(string[] args)
        {
            Console.WriteLine(FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12));
        }

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                var target = sum - list[i];

                if (dict.ContainsKey(target))
                {
                    return new Tuple<int, int>(dict[target], i);
                }

                if (!dict.ContainsKey(list[i]))
                {
                    dict.Add(list[i], i);
                }
            }

            return null;
        }
    }


}
