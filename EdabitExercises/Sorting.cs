namespace ConsoleApp
{
    internal class Sorting
    {
        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.Write('\n');
        }

        public static void BubbleSort(int[] input)
        {
            // Make a coopy since an array passed by reference
            int[] result = new int[input.Length];
            Array.Copy(input, result, input.Length);

            // Show array before sorting
            Console.Write("Initial array:\t");
            PrintArray(result);

            // Algorithm
            int len = result.Length;
            bool swapped;

            for (int i = 0; i < len - 1; i++)
            {
                // If outer loop doesn't have swaps
                // it means the array is already sorted
                swapped = false;
                
                // -1 needs for the sake of optimization 
                // because in each outer iteration the 
                // biggest element will bubble up
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        Swap(ref result[j], ref result[j + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            // Show array after sorting
            Console.Write("Sorted array:\t");
            PrintArray(result);
        }

        public static void InsertionSort(int[] input)
        {
            // Make a coopy since an array passed by reference
            int[] result = new int[input.Length];
            Array.Copy(input, result, input.Length);

            // Show array before sorting
            Console.Write("Initial array:\t");
            PrintArray(result);

            // Algorithm
            int len = result.Length;
            for (int i = 1; i < len; i++)
            {
                int key = result[i];
                int j = i - 1;
                
                // j condition must be the first one
                // or out of bounds error happens
                while(j >= 0 && result[j] > key )
                {
                    Swap(ref result[j + 1], ref result[j]);
                    j--;
                }
            }

            // Show array after sorting
            Console.Write("Sorted array:\t");
            PrintArray(result);
        }

        public static void QuickSort(int[] input)
        {
            // Make a coopy since an array passed by reference
            int[] result = new int[input.Length];
            Array.Copy(input, result, input.Length);

            // Show array before sorting
            Console.Write("Initial array:\t");
            PrintArray(result);

            // Algorithm
            QuickSortMain(result, 0, result.Length - 1);

            // Show array after sorting
            Console.Write("Sorted array:\t");
            PrintArray(result);
        }

        static void QuickSortMain(int[] arr, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = arr[leftIndex];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSortMain(arr, leftIndex, j);
            if (i < rightIndex)
                QuickSortMain(arr, i, rightIndex);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a; 
            a = b; 
            b = temp;
        }
    }
}
