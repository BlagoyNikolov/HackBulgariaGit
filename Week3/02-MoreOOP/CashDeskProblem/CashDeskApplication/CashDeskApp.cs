using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskApplication {
    class CashDeskApp {
        static void Main(string[] args) {
            Console.WriteLine("The CashDesk Application\nList of commands:\n1. takebill <number> - adds a bill with value <number> to the cashdesk");
            Console.WriteLine("2. takebatch <number1> <number2> ... - adds a batch of bills to the cashdesk");
            Console.WriteLine("3. total - prints the total money in the cash desk");
            Console.WriteLine("4. inspect - prints detailed information of the money in the cashdesk");
            Console.WriteLine("5. exit - exits the application");

            bool flag = false;
            CashDesk.CashDesk desk = new CashDesk.CashDesk();
            StringBuilder sb = new StringBuilder();

            while (!flag) {
                sb.Append(Console.ReadLine());

                if (sb.ToString().Contains("takebill")) {
                    sb.Replace("takebill", "");
                    int amount = -1;
                    if (int.TryParse(sb.ToString(), out amount)) {
                        if (amount == 5 || amount == 10 || amount == 20 || amount == 50 || amount == 100)
                            desk.TakeMoney(new CashDesk.Bill(amount));
                        else
                            Console.WriteLine("That's not a valid bill", amount);
                    }
                    else
                        Console.WriteLine("Input error");
                }
                else if (sb.ToString().Contains("takebatch")) {
                    sb.Replace("takebatch", " ");
                    List<CashDesk.Bill> listOfBills = new List<CashDesk.Bill>();
                    string[] array = sb.ToString().Split(' ');
                    int amount = -1;
                    foreach (var bill in array) {
                        if (int.TryParse(bill, out amount)) {
                            if (amount == 5 || amount == 10 || amount == 20 || amount == 50 || amount == 100)
                                listOfBills.Add(new CashDesk.Bill(amount));
                            else
                                Console.WriteLine("That's not a valid bill", amount);
                        }
                    }
                    desk.TakeMoney(new CashDesk.BatchBill(listOfBills));
                }
                else if (sb.ToString().Contains("total")) {
                    Console.WriteLine("Total balance: {0}$", desk.Total());
                }
                else if (sb.ToString().Contains("inspect")) {
                    if (desk.Total() != 0)
                        desk.Inspect();
                    else
                        Console.WriteLine("Cash Desk balance: 0$");
                }
                else if (sb.ToString().Contains("exit")) {
                    flag = true;
                    Console.WriteLine("Exiting...");
                }
                sb.Clear();
            }

            //var a = new CashDesk.Bill(5);
            //var b = new CashDesk.Bill(10);
            //var c = new CashDesk.Bill(50);
            //var d = new CashDesk.Bill(100);

            //Console.WriteLine((int)a);
            //Console.WriteLine(a);

            //Console.WriteLine(a == b); // False
            //Console.WriteLine(a == c); // True
            //Console.WriteLine(a.Value());

            //List<CashDesk.Bill> bills = new List<CashDesk.Bill>();
            //bills.Add(new CashDesk.Bill(10));
            //bills.Add(new CashDesk.Bill(20));
            //bills.Add(new CashDesk.Bill(50));
            //bills.Add(new CashDesk.Bill(100));
            //bills.Add(new CashDesk.Bill(100));

            //var batch = new CashDesk.BatchBill(bills);

            //foreach (var bill in batch) {
            //    Console.WriteLine(bill);
            //}
            //Console.WriteLine(batch);

            //desk.TakeMoney(new CashDesk.Bill(100));
            //desk.TakeMoney(batch);
            //desk.TakeMoney(new CashDesk.Bill(10));

            //Console.WriteLine(desk.ToString()); // 390
            //desk.Inspect();
            //Console.WriteLine(desk.Total());
        }
    }
}