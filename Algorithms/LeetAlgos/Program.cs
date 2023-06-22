using System;
using System.Collections.Generic;
using System.ComponentModel;


public class Solution 
{
    //BINARY SEARCH

    //Given an array of integers nums which is sorted in ascending order,
    //and an integer target, write a function to search target in nums.
    //If target exists, then return its index. Otherwise, return -1.
    //You must write an algorithm with O(log n) runtime complexity.

    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    //FIRST BAD VERSION

    //You are a product manager and currently leading a team to develop a new product.
    //Unfortunately, the latest version of your product fails the quality check.
    //Since each version is developed based on the previous version, all the versions after a bad version are also bad.
    //Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one,
    //which causes all the following ones to be bad. You are given an API bool isBadVersion(version)
    //which returns whether version is bad.
    //Implement a function to find the first bad version.You should minimize the number of calls to the API.
    public int FirstBadVersion(int n)
    {
        int left = 1;
        int right = n;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (IsBadVersion(mid))
            {
                // The current version is bad, so move to the left half
                right = mid;
            }
            else
            {
                // The current version is good, so move to the right half
                left = mid + 1;
            }
        }
        return left;


    }

    private bool IsBadVersion(int mid)
    {
        throw new NotImplementedException("This was not Implemented");
        
    }

    //SEARCH INSERT POSITION

    //Given a sorted array of distinct integers and a target value,
    //return the index if the target is found.
    //If not, return the index where it would be if it were inserted in order.
    //You must write an algorithm with O(log n) runtime complexity.
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] < target)
                left = mid + 1;

            else
                right = mid - 1;
        }
        return left;
    }

    // SQUARES OF A SORTED ARRAY

    //Given an integer array nums sorted in non-decreasing order,
    //return an array of the squares of each number sorted in non-decreasing order.

    public int[] SortedSquares(int[] nums)
    {
        int[] SquaredArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            SquaredArray[i] = nums[i] * nums[i];
        }
        Array.Sort(SquaredArray);
        return SquaredArray;
    }

    //ROTATE ARRAYS

    //Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

    public void Rotate(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k % nums.Length == 0)
            return;

        int n = nums.Length;
        int[] temp = new int[n];
        Array.Copy(nums, temp, n);

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + k) % n;
            nums[newIndex] = temp[i];
        }
    }

    //MOVE ZEROS

    //Given an integer array nums, move all 0's to the end of it while maintaining
    //the relative order of the non-zero elements.
    //Note that you must do this in-place without making a copy of the array.


}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1. BINARY SEARCH ALGORITHM");
        Console.WriteLine(    "                      ");
        Solution solution = new Solution();
        int[] nums = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int target = 14;

        int result = solution.Search(nums, target);

        if (result != -1)
            Console.WriteLine($"   Target found at index {result}");
        else
            Console.WriteLine("Target not found");

        Console.WriteLine("----------------------------------");



        //Console.WriteLine("2: FIRST BAD VERSION");

        //Solution solution2 = new Solution();
        //int totalVersions = 300;

        //int firstBadVersion = solution.FirstBadVersion(totalVersions);

        //Console.WriteLine("The first bad version is: " + firstBadVersion);

        //Console.WriteLine("----------------------------------");



        Console.WriteLine("3: SEARCH INSERT POSITION");

        Solution solution3 = new Solution();
        int[] nums3 = { 1, 3, 5, 7, 9 };
        int target3 = 6;

        int result3 = solution.SearchInsert(nums3, target3);

        Console.WriteLine("The target would be inserted at index: " + result3);

        Console.WriteLine("4: SQUARES OF A SORTED ARRAY");

      
        int[] nums4 = { -4, -1, 0, 3, 10 };
        Solution solution4 = new Solution();
        int[] squaredArray = solution.SortedSquares(nums4);

        Console.WriteLine("Squared Array: [" + string.Join(", ", squaredArray) + "]");

        Console.WriteLine("5: ROTATE ARRAY");
        int[] nums5 = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Solution solution5 = new Solution();
        solution.Rotate(nums5, k);

        Console.WriteLine("Rotated Array: [" + string.Join(", ", nums5) + "]");
    }
}

