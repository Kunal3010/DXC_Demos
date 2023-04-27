namespace InheritanceDemo
{
    class Calculator
    {
        protected string name;
        public Calculator()
        {
            Console.WriteLine("This is Calculator");
        }
        public Calculator(int x)
        {
            Console.WriteLine("");
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b) 
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class ScientificCalculator : Calculator 
    {
 
        public ScientificCalculator() : base(10)
        {
            name = "john";
            Console.WriteLine("This is Scientific Calculator");
        }
        public new void Show()
        {
            Console.WriteLine("This is show mehtod of Sci Calculator class");
        }
        public int Square(int x)
        {
            return x * x;
        }
        public int Cube(int x)
        {
            return x * x *x ;
        }
        public int Factorial(int x)
        {
            int fact = 1;
            for(int i = 0; i < x; i++)
            {
                fact *= x;
            }
            return fact;
        }
       
    }
    class AICalculator : ScientificCalculator
    {
        public void Message()
        {
            Console.WriteLine("Welcome to AI Calculator");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AICalculator calc = new AICalculator();

        }
            
        
    }
}