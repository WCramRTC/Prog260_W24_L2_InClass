using System.Globalization;

namespace Prog260_W24_L2_InClass
{
    internal class Program
    {
        static int[] numbers = { 5, 8, 3, 2, 9, 1 };

        // Sorting Algorithms

        static void Main(string[] args)
        {


        }

        static void BubbleSortArray(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were swapped in inner loop, the array is already sorted.
                if (!swapped)
                    break;
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void ArrayFlipExample()
        {

        }
    }
}

//static void BubbleSortArray(int[] arr)
//{
//    int n = arr.Length;
//    bool swapped;

//    for (int i = 0; i < n - 1; i++)
//    {
//        swapped = false;
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                // Swap arr[j] and arr[j+1]
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//                swapped = true;
//            }
//        }

//        // If no two elements were swapped in inner loop, the array is already sorted.
//        if (!swapped)
//            break;
//    }
//}