using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfArrayHLRange
{
    class Calculator
    {

        public int RangeElementsSum(int[] elements)
        {
            int largest = 0;
            int largestIndex = 0;
            int smallest = 0;
            int smallestIndex = 0;
            int sum = 0;

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] >= elements[i - 1] && elements[i] >= largest)
                {
                    largest = elements[i];
                    largestIndex = i;
                }
            }

            for (int i = elements.Length - 1; i > 0; i--)
            {
                if (elements[i] <= elements[i - 1] && elements[i] <= smallest)
                {
                    smallest = elements[i];
                    smallestIndex = i;
                }
            }

            if (elements[0] >= largest)
            {
                largestIndex = 0;

            }

            if (elements[0] <= smallest)
            {
                smallestIndex = 0;
            }

            if (largestIndex > smallestIndex)
            {
                int swapSum = largestIndex + smallestIndex;
                largestIndex = swapSum - largestIndex;
                smallestIndex = swapSum - smallestIndex;
            }

            for (int i = largestIndex; i <= smallestIndex; i++)
            {
                sum += elements[i];
            }

            return sum;
        }
    }
}
