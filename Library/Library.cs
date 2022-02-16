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

        public List<Book> GetBooks()
        {
            return this.bookList;
        }

        public Book FindBook(int id)
        {
            return bookList.Find(x => x.id == id);
        }
        public List<Book> AddBook(Book b)
        {
            Book book1 = FindBook(b.id);
            if (book1 == null)
                bookList.Add(b);
            else
                throw new Exception("Book already exist");

            return bookList;
        }
        public string RemoveBook(Book b)
        {
            Book book1 = FindBook(b.id);
            if (book1 != null)
                bookList.Remove(b);
            else
                throw new Exception("Book doesnt exist");
            
            return "Book removed!";
        }

        public string IssueBook(Book b, User u)
        {
            foreach (var i in bookList)
            {
                if (i.title.Equals(b.title) && i.check())
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
                if (i.title.Equals(b.title))
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
