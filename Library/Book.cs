using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        private bool inUseByUser = false;
        private int copies;
        public int id { get; set; }
        private float price;
        public string title { get; set; }
        public string language { get; set; }


        public Book(int id, string bookTitle, string bookLanguage, int copies)
        {
            this.id = id;
            this.title = bookTitle;
            this.language = bookLanguage;
            this.copies = copies;

        }       
        
        public int getCopies()
        {
            return this.copies;
        }

        public void setUser(bool b)
        {
            this.inUseByUser = b;
        }
        public bool check()
        {
            return this.inUseByUser;
        }
    }
}
