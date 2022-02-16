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
                throw new Exception("Book already exists");

            return bookList;
        }
        public string RemoveBook(Book b)
        {
            Book book1 = FindBook(b.id);
            if (book1 != null)
                bookList.Remove(b);
            else if(book1 == null)
                throw new Exception("Book does not exist");
            
            return "Book removed!";
        }

        public string IssueBook(Book b, User user)
        {
            Book book1 = FindBook(b.id);
            if (book1 == null)
            {
                throw new Exception("Book does not exist");
            }
            foreach (var i in bookList)
            {                
                if (i.title.Equals(b.title) && i.check())
                {
                    i.setUser(true);
                    user.subscribe(i);

                }
            }
            return "Book issued!";
        }
        public string ReturnBook(Book b, User user)
        {
            Book book1 = FindBook(b.id);
            if (book1 == null)
            {
                throw new Exception("Book does not exist");
            }
            foreach (var i in bookList)
            {
                if (i.title.Equals(b.title))
                {
                    i.setUser(false);
                    user.unsubscribe(i);
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
