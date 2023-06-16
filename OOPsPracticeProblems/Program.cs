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
                Console.WriteLine("\nSelect option \n1.Duplicate Elements in array \n2.Unique Element in array \n3.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}