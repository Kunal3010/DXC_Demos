//Exercise 1
int[] arr = { 7, 4, 5, 6, 8, 2, 3, 1 };

foreach (int i in arr)
{
    Console.Write(i + " ");
}
Console.WriteLine();

int num = 0;
foreach (int i in arr)
{
    if (i > num)
        num = i;
}
Console.WriteLine("The largest number in the array " + num);
