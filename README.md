# Prog260_W24_L2_InClass

https://www.geeksforgeeks.org/bubble-sort/
```csharp
using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        BubbleSortArray(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
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

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

```

https://www.geeksforgeeks.org/insertion-sort/#

```csharp
using System;

class InsertionSort
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        InsertionSortArray(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static void InsertionSortArray(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // Move elements of arr[0..i-1] that are greater than key
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

```


https://www.geeksforgeeks.org/selection-sort/

```csharp
using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        SelectionSortArray(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static void SelectionSortArray(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in the unsorted part of the array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element in the unsorted part
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

```

--- 

Recursive Methods


---

Flip Array

```csharp
class ArrayFlip
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        FlipArray(arr, 0, arr.Length - 1);

        Console.WriteLine("\nFlipped array:");
        PrintArray(arr);
    }

    static void FlipArray(int[] arr, int start, int end)
    {
        if (start >= end)
            return;

        // Swap the elements at start and end positions
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        // Recursive call on the remaining elements
        FlipArray(arr, start + 1, end - 1);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

```