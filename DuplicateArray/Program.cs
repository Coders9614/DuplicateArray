using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DuplicateCheck
    {
    //private object numbers;

    public bool DuplicateChk(int[] nums)
     {
        // Iterate through each element in the array
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // Compare the current element with every other element in the array
            for (int j = i + 1; j < nums.Length; j++)
            {
                // If any two elements are equal, a duplicate is found
                if (nums[i] == nums[j])
                {
                    return true; // Duplicate found
                }
            }
        }
    

            // If no duplicates were found, return false
            return false;
     }


        public static void Main(string[] args)
        {
            DuplicateCheck checker = new DuplicateCheck();

            // Example 1
            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine($"nums1's arry is {checker.DuplicateChk(nums1)}"); // Output: true

            // Example 2
            int[] nums2 = { 1, 2, 3, 4 };
            Console.WriteLine($"nums2's arry is {checker.DuplicateChk(nums2)}"); // Output: false

            // Example 3
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine($"nums3's arry is {checker.DuplicateChk(nums3)}"); // Output: true
        Console.ReadKey();
        }
    }





