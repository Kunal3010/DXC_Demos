namespace myStack
{
    class MyStack<T>
    {
        public int Count;
        public T[] arr;
        public MyStack() 
        {
            arr = new T[10];
            Count = 0;
        }

        public void Push(T obj)
        {
            arr[Count++] = obj;
        }
        public T Pop()
        {
            T item = arr[Count-1];
            Count--;
            return item;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            int j = 0;
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            foreach (int i in myStack.arr)
            {
                int p = 0;
                Console.WriteLine($"Pushed element{++p} : {i}");
            }
            Console.WriteLine($"Number of objects in the stack = {myStack.Count}");

            Console.WriteLine($"Poped item - {++j} is: {myStack.Pop()}");
            Console.WriteLine($"Poped item - {++j} is: {myStack.Pop()}");
            Console.WriteLine($"Poped item - {++j} is: {myStack.Pop()}");
        }
    }
}