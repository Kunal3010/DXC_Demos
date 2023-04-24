int[] arr = new int[10];
double sum = 0;

Console.WriteLine("Enter 10 numbers:");

foreach (int i in arr)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    sum += arr[i];
}
double avg = sum / arr.Length;

Console.WriteLine("The average of the numbers is: " + avg);