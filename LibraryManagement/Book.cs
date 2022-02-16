using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        private string title, language;
        private bool inUseByUser = false;
        private int copies;
        private float price;
    

    public Book(string bookTitle, string language, int copies)
        {
            this.title = bookTitle;
            this.language = language;
            this.copies = copies;

        }

        public string getTitle()
        {
            return this.title;
        }
        public string getLanguage()
        {
            return this.language;
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
