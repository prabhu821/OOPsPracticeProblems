using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class DuplicateElements
    {
        public int CountDuplicateElements(int[] array)
        {
            int count = 0;
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            // Count the occurrences of each element in the array
            foreach (int element in array)
            {
                if (elementCount.ContainsKey(element))
                    elementCount[element]++;
                else
                    elementCount[element] = 1;
            }

            // Count the duplicate elements
            foreach (int value in elementCount.Values)
            {
                if (value > 1)
                    count++;
            }

            return count;
        }
    }
}
