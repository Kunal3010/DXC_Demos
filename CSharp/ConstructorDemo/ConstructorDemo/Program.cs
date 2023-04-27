namespace ConstructorDemo
{
    class Demo
    {
        public Demo()
        {
            Console.WriteLine("I am Constructor");
        }

        public Demo(int x)
        {
            Console.WriteLine("This is overloaded constructor");
        }

        public Demo(string x) 
        {
            Console.WriteLine("This is a string");
        }
        public void Show()
        {
            Console.WriteLine("This is shows method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Demo d1 = new Demo(10);
            Demo d2 = new Demo("Hello");
            d.Show();
        }
    }
}