using System;

namespace Task_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Min(45,91,63,10,120,3,15));
        }
        static int Min(params int[] arr)
        {
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i]) min = arr[i];
            }
            return min;
        }

    }
}
