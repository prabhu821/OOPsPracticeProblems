using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class FrequencyElements
    {
        public Dictionary<int, int> CountElementFrequency(int[] array)
        {
            Dictionary<int, int> elementFrequency = new Dictionary<int, int>();

            // Count the frequency of each element in the array
            foreach (int element in array)
            {
                if (elementFrequency.ContainsKey(element))
                    elementFrequency[element]++;
                else
                    elementFrequency[element] = 1;
            }

            return elementFrequency;
        }
    }
}
