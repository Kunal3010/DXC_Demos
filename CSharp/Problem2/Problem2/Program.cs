namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Degree Celsius");
            float temp = Convert.ToInt16(Console.ReadLine());
            float temp2 = ((float)(temp * 1.8 + 32));
            Console.WriteLine("Temperature in Fahrenheit");
            Console.WriteLine(temp2);


       }
    }
}