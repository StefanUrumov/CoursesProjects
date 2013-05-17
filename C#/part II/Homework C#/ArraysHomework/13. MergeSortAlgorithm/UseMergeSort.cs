using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MergeSort
{
    public static void Main()
    {
        int[] array = new int[] { 2, 3, 1, 6, 2, 8, 4, 10, 7, 3, 5,  0, 9 };

        Console.WriteLine("Array of numbers before sorting:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        Sort(array, 0, array.Length - 1);

        Console.WriteLine();
        Console.WriteLine("Same array after using merge sort algorithm:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    public static void Sort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            Sort(data, left, middle);
            Sort(data, middle + 1, right);
            Merge(data, left, middle, middle + 1, right);
        }
    }

    public static void Merge(int[] data, int left, int middle, int middle1, int right)
    {
        int oldPosition = left;
        int size = right - left + 1;
        int[] tempArray = new int[size];
        int i = 0;

        while (left <= middle && middle1 <= right)
        {
            if (data[left] <= data[middle1])
                tempArray[i++] = data[left++];
            else
                tempArray[i++] = data[middle1++];
        }
        if (left > middle)
            for (int j = middle1; j <= right; j++)
                tempArray[i++] = data[middle1++];
        else
            for (int j = left; j <= middle; j++)
                tempArray[i++] = data[left++];
        Array.Copy(tempArray, 0, data, oldPosition, size);
    }
    
}