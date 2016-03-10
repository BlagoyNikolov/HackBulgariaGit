using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesAndMethodsClassLibrary {
    public partial class Employee {
        //       void Print() - partial method which should print first name together with last name
        //       CalculateAllIncome() => Salary + Bonus
        //       CalculateBalance() => Salary + Bonus - Taxes
        partial void Print() {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Position: {2}", FirstName, LastName, Position);
        }

        public decimal CalculateAllIncome() {
            Console.WriteLine("Total Income: {0}", Salary + Bonus);
            return Salary + Bonus;
        }

        public decimal CalculateBalance() {
            Console.WriteLine("Current Balance: {0}", Salary + Bonus - Taxes);
            return Salary + Bonus - Taxes;
        }

        public void PrintEmployee() {
            Print();
        }
    }
}
