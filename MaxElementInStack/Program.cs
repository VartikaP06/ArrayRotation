namespace LinearSearch
{
    using System;

    class Solution
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] { 2, 3, 4, 10, 40 };

            Console.WriteLine("Enter the number to search");
            var isNumber = int.TryParse(Console.ReadLine(), out var item);

            if (!isNumber)
            {
                Console.WriteLine("Please enter a valid number to search");
            }
            else
            {
                var index = LinearSearch(item, inputArray);
                if(index == -1)
                {
                    Console.WriteLine("Sorry! The item was not found in the array");
                }
                else
                {
                    Console.WriteLine($"We found the item at position {index + 1}");
                }
            }

            Console.WriteLine();
        }

        static int LinearSearch(int item, int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
