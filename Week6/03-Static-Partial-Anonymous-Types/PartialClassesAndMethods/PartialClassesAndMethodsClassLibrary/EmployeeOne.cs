using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesAndMethodsClassLibrary {
    public partial class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public decimal Bonus { get; set; }
        public decimal Taxes { get; set; }

        public Employee(string firstName, string lastName, decimal salary, string position, decimal bonus, decimal taxes) {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Position = position;
            Bonus = bonus;
            Taxes = taxes;
        }

        partial void Print();
    }
}
