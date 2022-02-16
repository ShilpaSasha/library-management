using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class User
    {
        string name, username;
        int id { get; set; }
        List<Book> books;
        public User(string name, int id)
        {
            this.id= id; 
            this.name= name;
}
        public void subscribe(Book b)
        {
            books.Add(b);
        }
        
        public void unsubscribe(Book b)
        {
            books.Remove(b);
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public List<Book> GetBorroweedBookList()
        {
            return this.books;
        }

    }
}
