using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class SumOfDigits
    {
        public void Sum()
        {
            Console.WriteLine("Enter a digit");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0, b;
            while (a != 0)
            {
                b = a % 10; //extract a digit
                sum = sum + b; //adding the digits
                a = a / 10; //remained number
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
