using SimpleRESTServiceCRUD.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServiceCRUD.Repositories.Implementations
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int counter = 1;

        public BookRepository()
        {
            AddNew(new Book { Title = "Thinking in C#", ISBN = "65674523432423" });
            AddNew(new Book { Title = "Thinking in Java", ISBN = "34223434543423" });
            AddNew(new Book { Title = "Beginning WCF", ISBN = "35343532423" });
        }


        /// <summary>
        /// -- CREATED New book --
        /// </summary>
        /// <param name="newBook"></param>
        /// <returns></returns>
        public Book AddNew(Book newBook)
        {
            if (newBook == null)
                throw new ArgumentNullException("newBook");
            newBook.BookId = counter++;
            books.Add(newBook);
            return newBook;
        }

        /// <summary>
        /// -- RETRIEVE /ALL --
        /// </summary>
        /// <returns>List<Book></returns>
        public List<Book> GetAll()
        {
            return books;
        }
               
        /// <summary>
        /// -- RETRIEVE /By BookId --
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>Book</returns>
        public Book GetById(int bookId)
        {
            return books.Find(b => b.BookId == bookId);
        }


        /// <summary>
        /// -- UPDATE a book  --
        /// </summary>
        /// <param name="updatedBook"></param>
        /// <returns>bool</returns>
        public bool Update(Book updatedBook)
        {
            if (updatedBook == null)
                throw new ArgumentNullException("updatedBook");

            int idx = books.FindIndex(b => b.BookId == updatedBook.BookId);
            if (idx == -1)
                return false;

            books.RemoveAt(idx);
            books.Add(updatedBook);
            return true;
        }

        /// <summary>
        /// -- DELETE a book  --
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>bool</returns>
        public bool Delete(int bookId)
        {
            int idx = books.FindIndex(b => b.BookId == bookId);
            if (idx == -1)
                return false;

            books.RemoveAll(b => b.BookId == bookId);
            return true;
        }

        /*
        private List<Book> books = new List<Book>();
        private int counter = 1;

        public BookRepository()
        {
            AddNewBook(new Book { Title = "Thinking in C#", ISBN = "65674523432423" });
            AddNewBook(new Book { Title = "Thinking in Java", ISBN = "34223434543423" });
            AddNewBook(new Book { Title = "Beginning WCF", ISBN = "35343532423" });
        }

        //CRUD Operations
        //1. CREAT
        public Book AddNewBook(Book newBook)
        {
            if (newBook == null)
                throw new ArgumentNullException("newBook");
            newBook.BookId = counter++;
            books.Add(newBook);
            return newBook;
        }

        //2. RETRIEVE /ALL
        public List<Book> GetAllBooks()
        {
            return books;
        }

        //3. RETRIEVE /By BookId
        public Book GetBookById(int bookId)
        {
            return books.Find(b => b.BookId == bookId);
        }

        //4. UPDATE
        public bool UpdateABook(Book updatedBook)
        {
            if (updatedBook == null)
                throw new ArgumentNullException("updatedBook");

            int idx = books.FindIndex(b => b.BookId == updatedBook.BookId);
            if (idx == -1)
                return false;

            books.RemoveAt(idx);
            books.Add(updatedBook);
            return true;
        }

        //5. DELETE
        public bool DeleteABook(int bookId)
        {
            int idx = books.FindIndex(b => b.BookId == bookId);
            if (idx == -1)
                return false;

            books.RemoveAll(b => b.BookId == bookId);
            return true;
        }
        */
    }
}