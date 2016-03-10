using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazinesClassLibrary {
    public static class MagazineAndBookSorter {
        public static List<string> Sort(List<Book> books, List<Magazine> magazines) {

            List<Edition> result = new List<Edition>();
            foreach (var book in books) {
                result.Add(new Edition(book));
            }

            foreach (var magazine in magazines) {
                result.Add(new Edition(magazine));
            }

            return result.OrderBy(order => order.EditionName).ThenBy(order => order.Order).Select(order => order.EditionName).ToList();
        }

        class Edition {
            public string EditionName { get; set; }
            public int Order { get; set; }

            public Edition(Book book) {
                EditionName = book.Name;
                Order = book.Id;
            }

            public Edition(Magazine magazine) {
                EditionName = magazine.Title;
                Order = magazine.ISBN;
            }
        }
    }
}
