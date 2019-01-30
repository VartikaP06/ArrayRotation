namespace MaxElementInStack
{
    using System;

    class Solution
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Rotation Index");
            var abc = int.TryParse(Console.ReadLine(), out var rotIdx);

            if(rotIdx > 0)
            {
                var rotatedArray = Rotation(rotIdx, inputArray);
                for (int i = 0; i < rotatedArray.Length; i++)
                {
                    Console.Write(rotatedArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine();
        }

        static int[] Rotation(int rotateIndex, int[] arr1)
        {
            var arrayLength = arr1.Length;
            var arr2 = new int[arrayLength];
            
            var rIdx = rotateIndex % arrayLength;

            if (rIdx == 0)
            {
                return arr1;
            }

            int lastIndex = arrayLength - rIdx;
            for (int i = 0; i < arrayLength; i++)
            {
                if (i < rIdx)
                {
                    arr2[lastIndex++] = arr1[i];
                }
                else
                {
                    arr2[i - rIdx] = arr1[i];
                }
            }

            return arr2;
        }
    }
}
