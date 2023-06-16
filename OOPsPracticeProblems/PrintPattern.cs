using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class PrintPattern
    {
        public void Print1()
        {
            int rows = 7; // Number of rows in the pattern
            int columns = 7; // Number of columns in the pattern

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == columns)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
