namespace OOPsPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOPs Practice Problems!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect option \n1.Duplicate Elements in array \n2.Unique Element in array " +
                    "\n3.Frequency of Elements in array \n4.Pattern Print \n5.Print Pattern \n6.Sum of digits \n7.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        DuplicateElements duplicateElements = new DuplicateElements();
                        int[] arr = { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9 };
                        int duplicateCount = duplicateElements.CountDuplicateElements(arr);
                        Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
                        break;
                    case 2:
                        UniqueElements uniqueElements = new UniqueElements();
                        int[] arr1 = { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9 };
                        Console.WriteLine("Unique elements in the array:");
                        uniqueElements.PrintUniqueElements(arr1);
                        break;
                    case 3:
                        FrequencyElements frequencyElements = new FrequencyElements();  
                        int[] arr2 = { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9 };
                        Dictionary<int, int> frequencyMap = frequencyElements.CountElementFrequency(arr2);
                        Console.WriteLine("Element\tFrequency");
                        foreach (KeyValuePair<int, int> kvp in frequencyMap)
                        {
                            Console.WriteLine(kvp.Key + "\t" + kvp.Value);
                        }
                        break;
                    case 4:
                        PatternPrint patternPrint = new PatternPrint();
                        patternPrint.Print();
                        break;
                    case 5:
                        PrintPattern printPattern = new PrintPattern();
                        printPattern.Print1();
                        break;
                    case 6:
                        SumOfDigits sumOfDigits = new SumOfDigits();
                        sumOfDigits.Sum();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}