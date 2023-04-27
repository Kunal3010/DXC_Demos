namespace StaticDemo
{
    class Demo
    {
        static int num = 0;
        public void increment () 
        {
            num++;
            Console.WriteLine(num);
        }
        public static void Show()
        {
            Console.WriteLine("This is a Show Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();    
            Demo d2 = new Demo();
            Demo d3 = new Demo();
            d1.increment();
            d2.increment();
            d3.increment();
            Demo.Show();
            
        }
    }
}