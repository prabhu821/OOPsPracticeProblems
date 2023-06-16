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
                Console.WriteLine("\nSelect option \n1.Count Duplicate Elements in array \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        DuplicateElements duplicateElements = new DuplicateElements();
                        int[] arr = { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 8, 8, 9 };
                        int duplicateCount = duplicateElements.CountDuplicateElements(arr);
                        Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}