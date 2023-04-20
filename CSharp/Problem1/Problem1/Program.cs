namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth of the rectangle");
            int length = Convert.ToInt16(Console.ReadLine());
            int breadth = Convert.ToInt16(Console.ReadLine());
            int perimeter = 2*(length + breadth);
            Console.WriteLine("The Perimeter of the Rectangle is ");
            Console.WriteLine(perimeter);
        }
    }
}