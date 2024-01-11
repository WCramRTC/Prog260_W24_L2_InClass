# Prog260_W24_L2_InClass

Bubble sort is called a "bubble sort" because it repeatedly steps through the list to be sorted, compares adjacent elements, and swaps them if they are in the wrong order. During each pass through the list, the largest unsorted element "bubbles up" to its correct position at the end of the list, which is similar to how bubbles rise to the surface in a liquid. 

The algorithm is named for the way elements seem to move up through the list as they are sorted, with smaller elements moving upwards (towards the beginning of the list) like bubbles rising in water. However, it's important to note that bubble sort is not an efficient sorting algorithm and is mainly used for educational purposes or for small datasets where simplicity of implementation is more important than sorting speed. In practical applications, more efficient sorting algorithms are preferred.

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

Certainly! Here's a detailed C# implementation of the bubble sort algorithm with comments explaining each step:

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

            // Last i elements are already in place, so we don't need to compare them again.
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare adjacent elements.
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1] if they are in the wrong order.
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the array is already sorted.
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

Here's what's happening in the code:

1. We define an integer array `arr` with the elements to be sorted.

2. We print the original array using the `PrintArray` method.

3. We call the `BubbleSortArray` method to sort the array.

4. In the `BubbleSortArray` method:
   - We initialize the variables `n` to the length of the array and `swapped` to `false`. `swapped` is used to check if any elements were swapped during an iteration.
   - We have two nested loops. The outer loop runs through the elements from the beginning to the second-to-last element (i.e., `n - 1` iterations).
   - The inner loop compares adjacent elements in the array and swaps them if they are in the wrong order.
   - If no elements were swapped during an inner loop iteration, it means the array is already sorted, so we break out of the loop early.
   
5. After sorting, we print the sorted array using the `PrintArray` method.

The bubble sort algorithm repeatedly compares adjacent elements and swaps them if necessary, "bubbling" the largest elements to the end of the array in each pass, until the entire array is sorted.

---

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