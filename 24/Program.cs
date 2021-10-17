using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 4, 5, 6, 7, 4, 2, 234, 45, 56, 4, 3, 234 };
            for (int i = 1; i < arr.Length-1; i++)
            {

                    if (arr[i - 1] % 2 == 0 && arr[i + 1] % 2 == 0 && arr[i] < arr[i + 1] && arr[i] < arr[i - 1])
                    {
                    Console.WriteLine(arr[i]);
                    }
                
            }
        }
    }
}
