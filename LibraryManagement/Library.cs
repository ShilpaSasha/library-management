using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        List<Book> bookList = new List<Book>();
        List<User> userList = new List<User>();
        public string AddBook(Book b)
        {
            bookList.Add(b);
            return "Book added!";
        }
        public string RemoveBook(Book b)
        {
            bookList.Remove(b);
            return "Book removed!";
        }

        public string IssueBook(Book b, User u)
        {
            foreach (var i in bookList)
            {
                if (i.getTitle().Equals(b.getTitle()) && i.check())
                {
                    i.setUser(true);
                    bookList.Remove(i);
                    bookList.Add(i);
                    u.subscribe(i);

                }
            }
            return "Book issued!";
        }
        public string ReturnBook(Book b, User u)
        {
            foreach (var i in bookList)
            {
                if (i.getTitle().Equals(b.getTitle()))
                {
                    i.setUser(false);
                    bookList.Remove(i);
                    bookList.Add(i);
                    u.unsubscribe(i);
                }
            }
            return "Book returned!";
        }

        public bool Checkbook(Book b)
        {   if(b == null)
            {
                Console.WriteLine("Book not available");
                return false;
            }
            return b.check();
        }

        public void notify()
        {
        }
    }
    
}
