using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> {

        private class Node {
            private T value;
            private Node next;

            public T Value { get { return value; } set { this.value = value; } }
            public Node Next { get { return next; } set { next = value; } } 
        }

        Node Head;
    }
}
