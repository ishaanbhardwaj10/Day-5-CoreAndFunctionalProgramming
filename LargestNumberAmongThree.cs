using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProgramming
{
    public static class LargestNumberAmongThree
    {
        public static void FindTheLargest()
        {
            Console.Write("Enter three numbers to find the largest number among them\nEnter first number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int numThree = Convert.ToInt32(Console.ReadLine());

            if(numOne >= numTwo && numOne >= numThree)
            {
                Console.WriteLine("Largest number is: " + numOne);
            }
            else if (numTwo > numOne && numTwo > numThree)
            {
                Console.WriteLine("Largest number is: " + numTwo);
            }
            else
            {
                Console.WriteLine("Largest number is: " + numThree);
            }
        }
    }
}
