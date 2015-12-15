using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack {
    class Stack<T> {
        private T[] data { get; set; }
        private int capacity { get; set; }
        private int top { get; set; }

        public Stack(int capacity) {
            this.capacity = capacity;
            data = new T[capacity];
            top = -1;
        }

        public Peek() {

        }

        public Pop() {

        }

        public Push(T) {

        }

        public Clear() {

        }

        public Contains(T) {

        }
    }
}
