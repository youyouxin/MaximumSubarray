
namespace MaximumSubarray
{
    public class MaximumSubarray
    {
        private static (int ,int ,int) findMaxCrossingSubarray(int[] A, int low, int mid, int high)
        {
            int leftSum = int.MinValue;
            int sum = 0;
            int maxLeft = 0;
            for(int i = mid; i >= low; i--)
            {
                sum += A[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }
            }
            int rightSum = int.MinValue;
            sum = 0;
            int maxRight = 0;
            for(int j = mid + 1; j <= high; j++)
            {
                sum += A[j];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    maxRight = j;
                }
            }
            return (maxLeft, maxRight, leftSum + rightSum);
        }
        public static (int,int,int) findMaximumSubarray(int[] A,int low,int high)
        {
            if(high == low)
            {
                return (low, high, A[low]);
            }
            else
            {
                int mid = (low + high) / 2;
                (int leftLow, int leftHigh, int leftSum) = findMaximumSubarray(A, low, mid);
                (int rightLow, int rightHigh, int rightSum) = findMaximumSubarray(A, mid + 1, high);
                (int crossLow, int crossHigh, int crossSum) = findMaxCrossingSubarray(A, low, mid, high);
                if (leftSum >= rightSum && leftSum >= crossSum)
                    return (leftLow, leftHigh, leftSum);
                else if (rightSum >= leftSum && rightSum >= crossSum)
                    return (rightLow, rightHigh, rightSum);
                else
                    return (crossLow, crossHigh, crossSum);
            }
        }
    }
}
