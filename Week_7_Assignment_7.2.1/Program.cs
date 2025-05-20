using System.Runtime.CompilerServices;

namespace Week_7_Assignment_7._2._1
{
    internal class Program
    {
        //Implement shell sort on an unsorted array of numbers.Take the array input from user.


        static void Main(string[] args)
        {
            // Taking the input array
            Console.Write("How many elements would you like to have in the Array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element - " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Shell Sort O(n^2)
                int gap = arr.Length / 2;               
                while (gap > 0)
                {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                }
                gap /= 2;
            }

            Console.WriteLine("Sorted array: ");
            foreach(int i in arr) { 
                Console.WriteLine(i);
            } 
        }
    }
}
