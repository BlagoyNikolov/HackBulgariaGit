using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes {
    class Program {
        static void Main(string[] args) {
            GenericStack<int> stack = new GenericStack<int>();
            Console.WriteLine(stack.ToString());
            stack.Push(5);
            stack.Push(8);
            stack.Push(12);
            stack.Push(1);
            stack.Push(3);
            stack.Push(9);
            stack.Push(2);
            Console.WriteLine(stack.ToString());
            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Pop: {0} new top: {1}", stack.Peek(), stack.Pop());
            Console.WriteLine(stack.ToString());
            Console.WriteLine(stack.Contains(12));
            stack.Clear();
            Console.WriteLine(stack.ToString());

            GenericDequeue<int> queue = new GenericDequeue<int>();
            Console.WriteLine(queue.ToString());
            queue.AddToFront(1);
            queue.AddToFront(2);
            queue.AddToFront(3);
            queue.AddToFront(4);
            queue.AddToFront(5);
            queue.AddToFront(6);
            queue.AddToEnd(7);
            queue.AddToEnd(8);
            Console.WriteLine(queue.ToString());
            Console.WriteLine(queue.Contains(7));
            queue.RemoveFromEnd();
            queue.RemoveFromFront();
            Console.WriteLine(queue.ToString());
            Console.WriteLine("From end: {0}", queue.PeekFromEnd());
            Console.WriteLine("From front: {0}", queue.PeekFromFront());
            queue.Clear();
            Console.WriteLine(queue.ToString());

            PairRewrite<int, int> pair1 = new PairRewrite<int, int>(5, 10);
            PairRewrite<int, int> pair2 = new PairRewrite<int, int>(5, 10);
            PairRewrite<int, string> pair3 = new PairRewrite<int, string>(15, "test");
            PairRewrite<int, string> pair4 = new PairRewrite<int, string>(20, "test1");

            Console.WriteLine(pair1.ToString());
            Console.WriteLine(pair2.ToString());
            Console.WriteLine(pair3.ToString());
            Console.WriteLine(pair4.ToString());

            Console.WriteLine(pair1.Equals(pair2)); //true
            Console.WriteLine(pair1 == pair2); //true
            Console.WriteLine(pair1 != pair2); //false

            Console.WriteLine(pair3.Equals(pair4)); //false
            Console.WriteLine(pair3 == pair4); //false
            Console.WriteLine(pair3 != pair4); //true
        }
    }
}
