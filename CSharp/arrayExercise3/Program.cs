﻿int[] arr = { 1, 2, 3, 4, 8, 6, 7, 8, 9, 9 };
int count = 0;

foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
            break;
        }
    }
}



Console.WriteLine("The number of duplicate values in the array is: " + count);