using System;
using System.Collections.Generic;
using System.Linq;

namespace MTTechnicalQuestion1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public int[] joinArrays(int[] input1, int[] input2)
        {
            var list1 = input1.ToList();
            var list2 = input2.ToList();
            var list2Head = new List<int>();
            var result = new List<int>();

            do
            {
                list2Head = list2.Take(list1.Count).ToList();
                if (list1.SequenceEqual(list2Head))
                {
                    list2.RemoveRange(0, list1.Count);
                    result = input1.ToList();
                    result.AddRange(list2);
                    return result.ToArray();
                }
                list1.RemoveAt(0);

            } while (list1.Count > 0);

            result = input1.ToList();
            result.AddRange(list2);
            return result.ToArray();
        }
    }
}
