﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/palindrome-number
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x%10==0) return false;
            int fromLeft = x;
           
            var numberOfDigits = Math.Ceiling(Math.Log10(x));
            var midDigits = (int)Math.Ceiling((numberOfDigits/2));
            if (numberOfDigits == 0) return true;
            while (x > 0&& numberOfDigits>midDigits)
            {
                int rightDigit = x % 10;
                int leftDigit = (int)(fromLeft / Math.Pow(10, --numberOfDigits)) % 10;
                if (rightDigit!=leftDigit) {return false;}
                x /= 10;
            
            }
            return true;
        }
    }
}

