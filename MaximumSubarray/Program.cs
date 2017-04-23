using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            (int low, int high, int maxSum) = MaximumSubarray.findMaximumSubarray(A, 0, A.Length - 1);
            Console.WriteLine("low={0},high={1},maxSum={2}", low, high, maxSum);
        }
    }
}
