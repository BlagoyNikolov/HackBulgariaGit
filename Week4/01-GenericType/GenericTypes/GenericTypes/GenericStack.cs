using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes {
    class GenericStack<T> {
        private T[] data { get; set; } 
        private int capacity { get; set; }
        private int top { get; set; }

        public GenericStack() {
            data = new T[10];
            capacity = data.Length;
            top = -1;
        }

        public T Peek() {
            return data[top];
        }

        public T Pop() {
            T RemovedElement = data[top];
            top--;
            capacity--;
            return data[top];
        }

        public void Push(T element) {
            if (top != capacity - 1) {
                top++;
                data[top] = element;
            }
        }

        public void Clear() {
            top = -1;
        }

        public bool Contains(T element) {
            for (int i = 0; i < data.Length; i++) {
                if (data[i].Equals(element)) {
                    return true;
                }
            }
            return false;
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder();
            output.Append("Stack: ");
            for (int i = 0; i <= top; i++) {
                output.AppendFormat("{0} ", data[i]);
            }
            return output.ToString();
        }
    }
}
