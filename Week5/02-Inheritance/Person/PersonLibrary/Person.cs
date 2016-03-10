using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary {
    public abstract class Person {
        protected bool IsWoman {
            get; private set;
        }
        public Person(bool IsWoman) {
            this.IsWoman = IsWoman;
        }

        public abstract void DailyStuff();
        public override string ToString() {
            return String.Format("Person: woman: {0}", IsWoman);
        }
    }
}
