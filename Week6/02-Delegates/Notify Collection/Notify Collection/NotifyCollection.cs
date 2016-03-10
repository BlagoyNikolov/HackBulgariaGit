﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Notify_Collection {
    class NotifyCollection<T> : IList<T> {
        enum Operation { Add, Remove, Replace, ChangedProperty }
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly List<T> list = new List<T>();

        public T this[int index] {
            get {
                return list[index];
            }
            set {
                list[index] = value;
            }
        }

        public int Count {
            get {
                return list.Count;
            }
        }

        public bool IsReadOnly {
            get {
                return true; ;
            }
        }

        public void Add(T item) {
            list.Add(item);
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(Operation.Add.ToString() + " item."));
            }
        }

        public void Clear() {
            list.Clear();
        }

        public bool Contains(T item) {
            if (list.Contains(item)) {
                return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex) {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator() {
            return list.GetEnumerator();
        }

        public int IndexOf(T item) {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item) {
            list.Insert(index, item);
        }

        public bool Remove(T item) {
            if (list.Contains(item)) {
                list.Remove(item);
                if (PropertyChanged != null) {
                    PropertyChanged(this, new PropertyChangedEventArgs(Operation.Add.ToString() + " item."));
                }
                return true;
            }
            return false;
        }

        public void RemoveAt(int index) {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}
