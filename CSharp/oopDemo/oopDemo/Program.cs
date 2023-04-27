namespace oopDemo
{
    class Calculator
    {
        public void show()
        {
            Console.WriteLine("This is Show method");
        }

        public void SayHello(string message)
        {
            Console.WriteLine($"Hello {message}");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public void Add(int a, int b=0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.show();
            calc.SayHello("Kunal");
            calc.Sum(1, 2);
            int res = calc.Cube(3);
            Console.WriteLine(res);
            calc.Add(3,3,4);
        }
    }
}