using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ProductofArray
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length; //determines the size
            int[] answer = new int[n]; // final results

            // Left products
            int[] left_products = new int[n]; //creates an array
            left_products[0] = 1; // no elements to the left of the first element
            for (int i = 1; i < n; i++) // 
            {
                left_products[i] = left_products[i - 1] * nums[i - 1];
            }

            // Right products
            int[] right_products = new int[n];
            right_products[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                right_products[i] = right_products[i + 1] * nums[i + 1];
            }

            // Fill the answer array
            for (int i = 0; i < n; i++)
            {
                answer[i] = left_products[i] * right_products[i];
            }

            return answer;
        }

    }
}
