using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingBooksAndMagazinesClassLibrary;

namespace SortingBooksAndMagazinesApplication {
    class Program {
        static void Main(string[] args) {
            List<Book> books = new List<Book>();
            Book book1 = new Book("C#", 12);
            Book book2 = new Book("Vinetu", 23);
            Book book3 = new Book("Body Language", 31);
            Book book4 = new Book("Studentska Knijka", 27);
            Book book5 = new Book("Notebook", 5);
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            List<Magazine> mags = new List<Magazine>();
            Magazine mag1 = new Magazine("Top Gear", 16);
            Magazine mag2 = new Magazine("Fame", 28);
            Magazine mag3 = new Magazine("Shock", 38);
            Magazine mag4 = new Magazine("Cosmopolitan", 19);
            Magazine mag5 = new Magazine("Motor Trend", 1);
            mags.Add(mag1);
            mags.Add(mag2);
            mags.Add(mag3);
            mags.Add(mag4);
            mags.Add(mag5);

            foreach (var item in MagazineAndBookSorter.Sort(books, mags)) {
                Console.WriteLine(item);
            }
        }
    }
}
