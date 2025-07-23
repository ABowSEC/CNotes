using System.Collections.Generic;


public class Program
{


    public static void Main()
    {
        var numArr = new int[] { 87, 23, 1, 93, 2, 53 };
        numArr = MergeSort(numArr);
        Console.WriteLine(string.Join(",", numArr));
        numArr = Add(numArr, 42);
        Console.WriteLine(string.Join(",", numArr));

    }



    public static int[] MergeSort(int[] ints)
    {

        if (ints.Length <= 1)
        {
            return ints;
        }

        int middle = ints.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[ints.Length - middle];


        //Array.Copy(ints, 0, left, 0, middle);
        // or
        for (int i = 0; i < middle; i++)
        {
            left[i] = ints[i];
        }


        //Array.Copy(ints, middle, right, 0, ints.Length - middle); //
        // or
        for (int i = middle; i < ints.Length; i++)
        {
            right[i - middle] = ints[i];
        }


        int[] sortedLeft = MergeSort(left);
        int[] sortedRight = MergeSort(right);
        return Merge(sortedLeft, sortedRight);


    }

    public static int[] Merge(int[] left, int[] right)
    {
        int[] results = new int[left.Length + right.Length];
        int i = 0;
        int j = 0;
        int k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
            {
                results[k++] = left[i++];
            }
            else
            {
                results[k++] = right[j++];
            }
        }
        while (i < left.Length)
        {
            results[k++] = left[i++];
        }
        while (j < right.Length)
        {
            results[k++] = right[j++];
        }
        return results;
    }


    public static int[] Add(int[] ints, int num)
    {
        int[] results = new int[ints.Length + 1];
        for (int i = 0; i < ints.Length; i++)
        {
            results[i] = ints[i];
        }
        results[ints.Length] = num;
        return results;
    }
}