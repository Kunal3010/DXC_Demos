using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList list = new ArrayList();
             list.Add(10);
             list.Add(20);   //predefined method to add value
             list.Add("Hello");
             list.Add(2.5f);
             list.Add(true);

             foreach(object o in list)
             {
                 Console.WriteLine(o);
             }
             Console.WriteLine();

             list.Insert(2, "First insert");

             foreach (object o in list)
             {
                 Console.WriteLine(o);
             }
             Console.WriteLine();

             Console.WriteLine(list.Count);
             Console.WriteLine(list[2]);*/

            // Stack 

            /* Stack s = new Stack();
             s.Push(1);
             s.Push(2);
             s.Push(3);
             s.Push(4);

             Console.WriteLine(s.Contains(2));
             s.

             foreach (var item in s)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("After remove with pop method");
             Console.WriteLine($"{s.Pop()} is popped out ");
             foreach (var item in s) 
             {
                 Console.WriteLine(item);
             }*/

            // Queue

            /*Queue q = new Queue();  
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            Console.WriteLine("After removing");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }*/

            // Sorted List

            /*SortedList list = new SortedList();
            list.Add(5, "Five");
            list.Add(2, "Two");
            list.Add(3, "Three");
            list.Add(4, "Four");
            list.Add(1, "One");

            Console.WriteLine(list[3]);
            Console.WriteLine(list.GetByIndex(1));

            foreach (var item in list.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {list[item]}");
            }*/

            // Hash Table

            Hashtable ht = new Hashtable();
            ht.Add(5, "Five");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(1, "One");

            foreach(var item  in ht.Keys)
            {
                Console.WriteLine(item);
            }

        }
    }
}