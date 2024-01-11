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

        public static void BigONotationNotes()
        {
            // BigO (1)
            int element = numbers[1];

            // Big  (n)
            // n how many elements are in the array
            // 6 

            // Insertion and Bubble sort
            // BigO (n^2)
            // { 5, 8, 3, 2, 9, 1 }

            // for 6
            // 

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"i: {i} - j: {j} ");
                }
                Console.WriteLine();
            }

            // BigO (n^2)

            // BigO (logN)
            // { 5, 8, 3, 2, 9, 1 }


            // is this element what we are looking for? ==

            // {1,2,3,4,5,6,7,8,9,10} // Big O N
            // 0 9 : 4
            // 5 - 9 : 7 " 6 > 8 < 8
            // 5 - 6 5 : 
            // 4: 5 == 6? False 6 > 5 < 6


            // 1 {1,2,3,4,5,6,7,8,9,10}
            // 2 {,6,7,8,9,10}
            // 3 {,6,7,
            // 4 { 6 } 


            // Searching for 6
            // 100000
            // 50000
            // 25000



            // What we are looking for? ==
            // Is it greater than? >
            // Is it less than? <
        }

        static void InsertionSortArray(int[] arr)
        {
            int lastIndex = arr.Length;

            // I starts at 1
            for (int i = 1; i < lastIndex; i++)
            {
                int key = arr[i]; // current element
                int j = i - 1;

                // Move elements of arr[0..i-1] that are greater than key
                // to one position ahead of their current position

                // while j ( i - 1 ) >= 0
                // As long as j is not at the begging of the array
                // AND
                // { 5, 8, 3, 2, 9, 1 };
                // arr[0] > key

                // i next element
                // j is the current elemtn
                // j > current

                while (j >= 0 && arr[j] > key)
                {
                    // arr next element = current element
                    // j = j - 1
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void BubbleSortExample()
        {
            //// Loop through our array

            int[] rando = GenerateRandomArray(20, 5, 40);

            PrintArray(rando);


            BubbleSortME(rando);


            PrintArray(rando);

            //BubbleSortArray(numbers);
        }

        static void BubbleSortME(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Is the current value higher then the next value
                    int current = j;
                    int next = j + 1;

                    int currentNumber = arr[current];
                    int nextNumber = arr[next];

                    if (currentNumber > nextNumber)
                    {
                        //// Swapping
                        //int temp = currentNumber;
                        //currentNumber = nextNumber;
                        //nextNumber = temp;
                        int temp = arr[current];
                        arr[current] = arr[next];
                        arr[next] = temp;

                        swapped = true;
                    }    // Condition
                } // J Loop
                // If no two elements were swapped in inner loop, the array is already sorted.
                if (!swapped)
                    break;
            } // I loop
        }

        static void BubbleSortArray(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            // index 0 to index n - 1
            for (int i = 0; i < n - 1; i++)
            {
                // { 5, 8, 3, 2, 9, 1 };
                // i *  *  *  *  *
              // j0  *  *  *  *  *
              // j1  *  *  *  *
              // j2  *  *  *
                swapped = false;

                // Starting at the beggining of a collection
                // Move thru our elements one by one, till the second to last element
                // Each iteration, compare the current element to the next,
                // Move the larger element forward in the collection
                // Repeat until done

                for (int j = 0; j < n - i - 1; j++)
                {
                    int currentElement = j;
                    int nextElement = j + 1;

                    // Current = 8
                    // next = 3


                    if (arr[currentElement] > arr[nextElement])
                    {
                        // Swap arr[j] and arr[j+1]

                        int temp = arr[currentElement]; // [8,3] temp 8
                        arr[currentElement] = arr[nextElement]; // [3, 3] temp 8
                        arr[nextElement] = temp; // [3, 8 ]

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

        static int[] GenerateRandomArray(int count, int min, int max)
        {
            if (count > max - min + 1)
            {
                throw new ArgumentException("Cannot generate unique random numbers without repeats for the given range and count.");
            }

            Random rand = new Random();
            HashSet<int> uniqueNumbers = new HashSet<int>();
            int[] randomArray = new int[count];

            while (uniqueNumbers.Count < count)
            {
                int randomNumber = rand.Next(min, max + 1);

                if (!uniqueNumbers.Contains(randomNumber))
                {
                    uniqueNumbers.Add(randomNumber);
                    randomArray[uniqueNumbers.Count - 1] = randomNumber;
                }
            }

            return randomArray;
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