using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes {
    class GenericDequeue<T> {
        List<T> queue = null;

        public GenericDequeue() {
            queue = new List<T>();
        }

        public void Clear() {
            queue.Clear();
        }

        public bool Contains(T element) {
            foreach (var item in queue) {
                if (item.Equals(element)) {
                    return true;
                }
            }
            return false;
        }

        public T RemoveFromFront() {
            T removedElement = queue[0];
            queue.RemoveAt(0);
            return removedElement;
        }

        public T RemoveFromEnd() {
            T removedElement = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return removedElement;
        }

        public void AddToFront(T addedElement) {
            queue.Insert(0, addedElement);
        }

        public void AddToEnd(T addedElement) {
            queue.Add(addedElement);
        }

        public T PeekFromFront() {
            T peekElement = queue[0];
            return peekElement;
        }

        public T PeekFromEnd() {
            T peekElement = queue[queue.Count - 1];
            return peekElement;
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder();
            output.Append("Queue: ");
            foreach (var item in queue) {
                output.AppendFormat("{0} ", item);
            }
            return output.ToString();
        }
    }
}
