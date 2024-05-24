using System;

namespace ArrayBasics
{
	class ArrayBasics
	{
		static void Main(string[] args)
		{
			// To make random numbers
			Random rnd = new Random();
			// Creates new array that contains 10 int numbers
			int[] nums = new int[10];
			// Declaring sum to zero is to avoid any errors
			int sum = 0;
			// Declaring to 'MinValue' to ensure it works with any numbers (even negatives)
			int max = int.MinValue;

			Console.Write("Random Array: ");
			// Basic 'for' loop to create 10 random nubers that are in 1-99 range
			for (int i = 0; i < 10; i++)
			{
				nums[i] = rnd.Next(100);
				Console.Write(nums[i] + " ");
			}
			Console.WriteLine();
			// 'for' loop that runs by Array length and every loop sums array number
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}
			Console.WriteLine("Int Sum: " + sum);

			// 'for' loop that runs by Array length and
			// uses 'if' function to find Max number in Array
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > max)
				{
					max = nums[i];
				}
			}
			Console.WriteLine("Max Int: " + max);
			// It reverse Arrays number order 
            System.Array.Reverse(nums);
			Console.WriteLine("Reversed Array: " + string.Join(" ", nums));
		}
	}
}