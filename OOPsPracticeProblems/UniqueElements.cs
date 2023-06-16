using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class UniqueElements
    {
        public void PrintUniqueElements(int[] array)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            // Count the occurrences of each element in the array
            foreach (int element in array)
            {
                if (elementCount.ContainsKey(element))
                    elementCount[element]++;
                else
                    elementCount[element] = 1;
            }

            // Print the unique elements
            foreach (KeyValuePair<int, int> kvp in elementCount)
            {
                if (kvp.Value == 1)
                    Console.WriteLine(kvp.Key);
            }
        }
    }
}
