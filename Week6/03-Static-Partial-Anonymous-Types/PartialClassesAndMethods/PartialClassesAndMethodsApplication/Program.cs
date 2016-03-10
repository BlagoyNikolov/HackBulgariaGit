using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartialClassesAndMethodsClassLibrary;

namespace PartialClassesAndMethodsApplication {
    class Program {
        static void Main(string[] args) {
            Employee testSubject = new Employee("Blagoy", "Nikolov", 3000, "Senior Developer", 500, 750);
            testSubject.PrintEmployee();
            testSubject.CalculateAllIncome();
            testSubject.CalculateBalance();
        }
    }
}
