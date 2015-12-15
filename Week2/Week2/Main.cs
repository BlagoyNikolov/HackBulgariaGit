using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.BuiltInClasses;
using Week2.ProblemsInvolvingMethods;

namespace Week2 {
    class Main1 {
        static void Main(string[] args) {
            //Reverse a string
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //ReverseString.ReverseList(ref list);

            //Inflate a rectangle
            //Rectangle rect = new Rectangle(-4, -4, 12, 12);
            //Size size = new Size(2, 2);
            //InflateRectangle.Inflate(ref rect, size);

            //Search in a list
            //List<string> list = new List<string>() { "github" , "is", "awesome" };
            //string search = "awesome";
            //int index;
            //SearchInList.TryFindSubstring(list, search, out index);

            //Joining strings
            //Console.WriteLine(JoiningStrings.JoinStrings(",", "Chicago", "Paris", "Sofia", "New York"));

            //Factoriel Generator
            //foreach (var value in FactorielGenerator.GenerateFactorials(6)) {
            //    Console.WriteLine("The final value is: " + value);
            //}

            //Directory Traversal
            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Blagoy\Downloads");
            //string str = string.Join(Environment.NewLine, DirectoryTraversal.IterateDirectory(dir));

            //-----------------------------------------------------------------------------
            //Friday the 13th
            //Console.WriteLine(Friday.UnfortunateFridays(2015, 2016));

            //Date sums
            //DateSums.PrintDatesWithGivenSum(2015, 20);

            //1337
            //_1337.HackerTime();

            //Appointments intersection
            //DateTime[] startDate = new DateTime[] {
            //    new DateTime(2015, 10, 1, 17, 30, 00),
            //    new DateTime(2015, 10, 2, 13, 00, 00),
            //    new DateTime(2015, 10, 3, 14, 30, 00),
            //    new DateTime(2015, 10, 1, 14, 20, 00),
            //    new DateTime(2015, 10, 5, 17, 00, 00)
            //};

            //TimeSpan[] durations = new TimeSpan[] {
            //    new TimeSpan(2, 10, 0),
            //    new TimeSpan(3, 10, 0),
            //    new TimeSpan(2, 10, 0),
            //    new TimeSpan(5, 30, 0),
            //    new TimeSpan(2, 10, 0)
            //};
            
            //Appointments.FindIntersectingAppointments(startDate, durations);

            //Calendar
            //CalendarHack.PrintCalendar(12, 2015, new CultureInfo("bg-BG"));

            //Bank Account Balance
            BankAccountBalance.Balance("C:\\Users\\Blagoy\\Desktop\\pesho.txt");

            //Polygon Circumference and Area
            //PointF[] points = new PointF[] {
            //     new PointF(0,0), new PointF(3,0),
            //    new PointF(4,3), new PointF(2,5),
            //    new PointF(0,3)
            //};
            //PolygonCircumference.CalcCircumference(points);
            //PolygonArea.CalcArea(points);

            //Random Numbers
            //RandomFloat.GenerateRandomMatrix(5, 5, "C:\\Users\\Blagoy\\Desktop\\matrix.txt");

            //Clock angle
            //DateTime time = new DateTime(2015, 12, 1, 4, 30, 00);
            //Console.WriteLine("The angle between {0} and {1} is: {2} ",time.Hour, time.Minute, ClockAngle.GetClockHandsAngle(time, false));
        }
    }
}
