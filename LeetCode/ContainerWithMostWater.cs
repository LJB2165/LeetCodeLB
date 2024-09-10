using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int MaxArea(int[] height) // array of integers
        {
            int left = 0; // pointer at left end; first element in the array
            int right = height.Length - 1; //pointer at right end; last index of the array
            int maxArea = 0; // variable that keeps track of the maximum water container

            while (left < right) // runs until left and right pointers meet
            {
                
                int currentHeight = Math.Min(height[left], height[right]); // is the minimum of the heights at the left and right pointers
                int currentWidth = right - left; // distance between pointers 
                int currentArea = currentHeight * currentWidth; // amount of water the current container can hold

                
                maxArea = Math.Max(maxArea, currentArea); // 1st iter Math.Max(0, 3) = 3

                
                if (height[left] < height[right]) //checks if the line at left is shorter than the one to the right.
                {
                    left++; // move left ponter one step to the right
                }
                else
                {
                    right--; // move the right pointer inward
                }
            }

            return maxArea; // return the maxArea once loop is complete
        }
    }
}
// Example Walkthrough with height = [1, 8, 6, 2]:
// Iteration 1:
// - left = 0 (height[0] = 1), right = 3 (height[3] = 2)
// - currentHeight = 1, currentWidth = 3, currentArea = 1 * 3 = 3
// - maxArea = 3
// - Since height[0] < height[3], move left to 1
// Iteration 2:
// - left = 1 (height[1] = 8), right = 3 (height[3] = 2)
// - currentHeight = 2, currentWidth = 2, currentArea = 2 * 2 = 4
// - maxArea = 4
// - Since height[1] > height[3], move right to 2
//once left == right the loop ends