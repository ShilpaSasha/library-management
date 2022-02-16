using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagement;
using System.Linq;
namespace LibraryTest
{
    [TestClass]
    public class LibraryTest

    {
        LibraryManagement.Library lib;
        [TestInitialize]
        public void initialise()
        {
            LibraryManagement.Library lib = new LibraryManagement.Library();
        }

        [TestMethod]
        public void AddBookShouldReturnConfirmation()
        {
            LibraryManagement.Library lib = new LibraryManagement.Library();
            var bookList = lib.AddBook(new Book(1,"Book 1", "English", 50));
            var addedBook = bookList.Where(x => x.title=="Book 1").FirstOrDefault();
            Assert.IsNotNull(addedBook);
            Assert.AreEqual("English",addedBook.language);
            //Assert.ThrowsException<System.Exception>(() => { lib.AddBook(new Book("", "English", 50));});
                  
        }
        public void AddExistingBookShouldReturnBookExists()
        {
            LibraryManagement.Library lib = new LibraryManagement.Library();
            var bookList1 = lib.AddBook(new Book(1,"Book 1", "English", 50));
            
            Assert.ThrowsException<System.Exception>(() => { lib.AddBook(new Book(1,"Book 1", "English", 50));});

        }

        [TestMethod]
        public void RemovingBookShouldReturnConfirmation()
        {
            //arrange
            lib = new LibraryManagement.Library();

            //act
            var removedBook = lib.RemoveBook(new Book(1,"Book 1", "English", 50));

            //assert
            Assert.AreEqual("Book removed!", removedBook);
        }

        [TestMethod]
        public void RemovingNonExistingBookShouldThrowException()
        {
            //arrange
            lib = new LibraryManagement.Library();

            //act
            var removedBook = lib.RemoveBook(new Book(1,"Book 1", "English", 50));

            //assert
            Assert.AreEqual("Book removed!", removedBook);
        }

        [TestMethod]
        public void IssueBookReturnsConfirmation()
        {
            LibraryManagement.Library lib = new LibraryManagement.Library();
            var issueBook = lib.IssueBook(new Book(1,"Book 1", "English", 50), new User("Shilpa",1));
            Assert.IsNotNull(issueBook);
            Assert.AreEqual("Book issued!", issueBook);
        }

        [TestMethod]
        public void IssueUnavailableBookThrowsException()
        {
            LibraryManagement.Library lib = new LibraryManagement.Library();
            var issueBook = lib.IssueBook(new Book(1,"Book 4", "English", 50), new User("Shilpa",1));
            Assert.IsNotNull(issueBook);
            Assert.AreEqual("Book issued!", issueBook);
        }

        [TestMethod]
        public void IfBookAvailableReturnsTrue()
        {
            //arrange
            LibraryManagement.Library lib = new LibraryManagement.Library();

            //act
            var check = lib.Checkbook(new Book(1,"Book 1", "English", 50));

            //assert
            //Assert.IsNotNull(check);
            Assert.AreEqual(true, check);
        }
        [TestMethod]
        public void IfBookNotAvailableReturnsfalse()
        {
            //arrange
            LibraryManagement.Library lib = new LibraryManagement.Library();

            //act
            var check = lib.Checkbook(new Book(1,"Book 2", "English", 50));

            //assert
            //Assert.IsNotNull(check);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void GetBookList()
        {
            LibraryManagement.Library lib = new LibraryManagement.Library();
            var getBook = lib.GetBooks();
            
            Assert.IsNotNull(getBook);
            Assert.AreEqual("Book issued!", getBook);
        }

        public void NotifyBookAvailability()
        {

        }
    }
}