namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principle amount");
            int P = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest");
            float R = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Time Period");
            int T = Convert.ToInt16(Console.ReadLine());
            float SI = (P*R*T)/100;
            Console.WriteLine("The Simple Interest is ");
            Console.WriteLine(SI);

        }
    }
}