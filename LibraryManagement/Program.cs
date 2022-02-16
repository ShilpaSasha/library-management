using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Program
{
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.AddBook(new Book("Book 1", "English", 50));

            Console.WriteLine("Select:1/2/3/4");
            Console.WriteLine("1. Add book \n2. Remove Book \n3. Issue Book \n4. Return Book \n5. Check Book");
            string x = Console.ReadLine();

            switch (x)
            {
                case "1": Console.WriteLine(lib.AddBook(new Book("Book 2", "English", 50))); break;
                case "2": Console.WriteLine(lib.RemoveBook(new Book("Book 1", "English", 50))); break;
                case "3": Console.WriteLine(lib.IssueBook(new Book("Book 2", "English", 50), new User("Shilpa"))); break;
                case "4": Console.WriteLine(lib.ReturnBook(new Book("Book 2", "English", 50), new User("Shilpa"))); break;
                case "5": Console.WriteLine(lib.Checkbook(new Book("Book 2", "English", 50))); break;
                default: Console.WriteLine(x); break;
            }
        }
    }
}
