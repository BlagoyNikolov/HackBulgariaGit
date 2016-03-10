using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary {
    public class Adult : Person {
        public bool IsBoring { get; set; }

        public Adult(bool gender) : base(gender) { }
        public Adult(bool gender, List<Child> children, bool IsBoring) : base(gender) {
            this.children = children;
            this.IsBoring = IsBoring;
        }

        List<Child> children;
        public override void DailyStuff() {
            Console.WriteLine("daily adult stuff");
        }
        public override string ToString() {
            if (children != null) {
                return String.Format("Adult: woman: {0} and has {1} children, Boring: {2}", IsWoman, children.Count, IsBoring);
            }
            else {
                return String.Format("Adult: woman: {0} and has no children, Boring: {1}", IsWoman, IsBoring);
            }
        }
    }
}
