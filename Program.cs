using System;
using System.Text;

namespace Csharp_Euler004
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Euler Challenge #4
                Find the largest palindrome made from the product of two 3-digit numbers.
                https://projecteuler.net/problem=4  */

            int bigPalin = 0;  int product = 0;

            for(int x = 999; x >= 100; x--)
            {
                for(int y = 999; y >= 100; y--)
                {
                    product = x * y;
                    if (isPalindrome(product))
                    {
                        if (product > bigPalin)
                        {
                            bigPalin = product;
                        }
                        // Now that a palindrome has been found, no need to check any other y's for this 'x', they can only be smaller.
                        break;
                    }
                }
            }
            Console.WriteLine("Euler Challenge #4\n\nThe largest palindrome made from the product of two 3-digit numbers = {0}.", bigPalin);
            Console.ReadLine();
        }

        static bool isPalindrome(int theNum)
        {   // given a number, returns true if it is a palindrome.  

            StringBuilder sNum = new StringBuilder(Convert.ToString(theNum));
            int length = sNum.Length;
            while (length > 1)
            {
                if(sNum[0] == sNum[length - 1])
                {
                    sNum.Remove(length-1, 1);
                    sNum.Remove(0, 1);
                    length = sNum.Length;
                }
                else{
                    return (false);
                }
            }
            return (true);
        }
    }
}
