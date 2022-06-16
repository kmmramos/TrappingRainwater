namespace Array_SumOfTarget
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Console.Write("Please enter the size of your array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] heights = new int[size];
                for (int i = 0; i < heights.Length; i++)
                {
                    Console.Write("Please enter your number: ");
                    heights[i] = Convert.ToInt32(Console.ReadLine());
                }

                int answer;
                answer = GetTrappedRainwater(heights);
                Console.WriteLine("Here is the total area of the trapped rainwater: {0}", answer.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //OPTIMAL SOLUTION
        public static int GetTrappedRainwater(int[] height)
        {
            int left = 0, right = height.Length - 1, leftMax = 0, rightMax = 0, total = 0;
            while (left < right)
            {
                if (height[left] <= height[right])
                {
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        total += leftMax - height[left]; ;
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        total += rightMax - height[right];
                    }
                    right--;
                }                
            }
            return total;
        }

        //NORMAL SOLUTION
        //public static int GetTrappedRainwater(int[] heights)
        //{
        //    int totalWater = 0;
        //    for (int p = 0; p < heights.Length; p++)
        //    {
        //        int leftP = p, rightP = p, maxLeft = 0, maxRight = 0;

        //        //determine maxLeft
        //        while (leftP >= 0)
        //        {
        //            maxLeft = Math.Max(maxLeft, heights[leftP]);
        //            leftP--;
        //        }

        //        //determine maxRight
        //        while (rightP < heights.Length)
        //        {
        //            maxRight = Math.Max(maxRight, heights[rightP]);
        //            rightP++;
        //        }

        //        int currentWater = Math.Min(maxLeft, maxRight) - heights[p];
        //        if (currentWater >= 0)
        //        {
        //            totalWater += currentWater;
        //        }
        //    }
        //    return totalWater;
        //}

    }
}