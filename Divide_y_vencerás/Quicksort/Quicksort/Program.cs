using System;

//Cristofer 

public class QuicksortExample
{
    public static void Quicksort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            Quicksort(arr, low, pi - 1);
            Quicksort(arr, pi + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; 
        int i = (low - 1); 

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1; 
    }

    public static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        int n = arr.Length;

        Quicksort(arr, 0, n - 1);

        Console.WriteLine("Array ordenado: ");
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }
}
