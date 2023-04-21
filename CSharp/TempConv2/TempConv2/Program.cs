namespace TempConv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ch;
            do
            {
                Console.WriteLine("Enter the Temperature in Degree Celsius: ");
                int temp = Convert.ToInt16(Console.ReadLine());

                double f = temp * 1.8 + 32;
                Console.WriteLine("Temperature(Celsius): " + temp + " Temperature(Fahrenheit): " + f);
                Console.WriteLine("Do You Wish to Continue(y/n)?");
                ch = Console.ReadLine();
            } while (ch =="y");
        }
    }
}